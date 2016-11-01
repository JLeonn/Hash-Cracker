Imports HashCracker.Backend.Hashing
Imports System.IO
Imports System.Security.Cryptography

Namespace HashAttacking
    ' Contains tools used for parsing .hash files.
    Public Class HashFileParser
#Region "Fields"
        Private _filePath As String
        Private reader As StreamReader
#End Region

#Region "Constructors"
        Public Sub New(ByVal filePath As String)
            If Path.GetExtension(filePath) = ".hash" Then
                Me.FilePath = filePath
                reader = New StreamReader(filePath)
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
        Public Iterator Function readHash() As IEnumerable(Of Hash)
            Do Until reader.Peek = -1
                Dim properties = parseHash(reader.ReadLine())
                Dim hashAlgorithm = determineAlgorithm(properties(2))
                Yield New Hash(properties(0), properties(1), hashAlgorithm)
            Loop
        End Function

        ' Parses line from hash file into three properties of a hash.
        ' TODO: Update this to use regular expressions. BUG, doesnt only remove the first occurances.
        Public Function parseHash(ByVal line As String) As List(Of String)
            Return line.Replace("Hash:", "").Replace("Salt:", "").Replace("HashType:", "").Replace(" ", "").Split(",").ToList()
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

