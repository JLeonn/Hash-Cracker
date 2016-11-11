Imports HashCracker.Backend.Hashing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Namespace HashAttacking
    ' Contains tools used for parsing .hash files.
    Public Class HashFileParser
#Region "Fields"
        Private _filePath As String
        Private _reader As StreamReader
#End Region

#Region "Constructors"
        Public Sub New(ByVal filePath As String)
            If Path.GetExtension(filePath) = ".hash" Then
                Me.FilePath = filePath
                _reader = New StreamReader(filePath)
            Else
                Throw New ArgumentOutOfRangeException("File Must Be .hash Format")
            End If
        End Sub
#End Region

#Region "Methods"
        ' Determines which hash class to return given a string.
        Private Function determineAlgorithm(ByVal algorithm As String) As HashAlgorithm
            Select Case algorithm
                Case "SHA512"
                    Return New SHA512Managed()
                Case "SHA384"
                    Return New SHA384Managed()
                Case "SHA256"
                    Return New SHA256Managed()
                Case "SHA1"
                    Return New SHA1Managed()
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select
        End Function

        ' Generates a hash type that was read and parsed from the given file path.
        Public Iterator Function readHashFile() As IEnumerable(Of Hash)
            Do Until _reader.Peek = -1
                Dim properties As Match = parse(_reader.ReadLine())
                Dim hashAlgorithm = determineAlgorithm(properties.Groups("type").Value)
                Yield New Hash(properties.Groups("hash").Value,
                               properties.Groups("salt").Value,
                               hashAlgorithm)
            Loop
        End Function

        ' Parses line from hash file into three properties of a hash.
        ' TODO: Update this to use regular expressions. BUG, doesnt only remove the first occurances.
        Public Function parse(ByVal line As String) As Match
            Dim pattern As New Regex("^Hash: (?<hash>.*), Salt: (?<salt>.*), HashType: (?<type>.*)")
            Dim match As Match = pattern.Match(line)

            If match.Success Then
                Console.WriteLine(match.Groups("hash").Value)
                Console.WriteLine(match.Groups("salt").Value)
                Console.WriteLine(match.Groups("type").Value)
                Return match
            Else
                Return Nothing
            End If
        End Function
#End Region

#Region "Properties"
        ' The path of the file that needs to but parsed.
        Public Property FilePath As String
            Get
                Return _filePath
            End Get
            Set(value As String)
                If Path.GetExtension(value) = ".hash" Then
                    _filePath = value
                Else
                    Throw New ArgumentOutOfRangeException("File Must Be .hash Format")
                End If
            End Set
        End Property
#End Region
    End Class
End Namespace

