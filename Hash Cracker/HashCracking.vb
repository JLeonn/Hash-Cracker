Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

' Module dedicated to cracking hashes.
' Current attacks: Bruteforce, Dictionary
Public Module HashCracking
    Public Interface Attacker
        ReadOnly Property Attempts As Long
        WriteOnly Property Run As Boolean
        Function attack(ByVal hash As Hash) As String
        Sub resetAttempts()
    End Interface


    ' Contains tools used to perform brute force attacks on password hashes.
    Public Class BruteForce : Implements Attacker
        Private _attempts As Integer
        Private _charset As String
        Private _minimum As Integer
        Private _maximum As Integer
        Private _run As Boolean

        Public Sub New(ByVal charset As String)
            _charset = charset
        End Sub

        Public Sub New(ByVal minimum As Integer, maximum As Integer)
            _minimum = minimum
            _maximum = maximum
        End Sub

        Public Sub New(ByVal charset As String, minimum As Integer, maximum As Integer)
            _charset = charset
            _minimum = minimum
            _maximum = maximum
        End Sub

        ' Starts the bruteforce cracking process.
        ' WARNING: May return null
        Public Function attack(ByVal hash As Hash) As String Implements Attacker.attack
            _run = True
            Dim passwords As IEnumerable(Of String) = generatePasswords(_minimum, _maximum)
            For Each password In passwords
                _attempts += 1
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password & hash.Salt)
                Dim hashBytes As Byte() = hash.Type.ComputeHash(bytes)
                If Convert.ToBase64String(hashBytes) = hash.Hash Then
                    Return password
                ElseIf Not _run Then
                    Return Nothing
                End If
            Next
            Return Nothing
        End Function

        ' Calculates the number of possible combinations and starts generating all of them.
        Public Iterator Function generatePasswords(ByVal min As Integer, max As Integer) As IEnumerable(Of String)
            For mini As Integer = min To max
                Dim total As Long = Math.Pow(Charset.Length, mini)
                Dim counter As Long = 0
                While counter < total
                    Yield factoradic(counter, mini - 1)
                    counter += 1
                End While
            Next
        End Function

        ' Generates each possible combination with the given
        Private Function factoradic(ByVal l As Long, power As Double) As String
            Dim sb As New StringBuilder
            While power >= 0
                sb = sb.Append(Charset((l Mod _charset.Length)))
                l /= _charset.Length
                power -= 1
            End While
            Return sb.ToString
        End Function

        Public Sub resetAttempts() Implements Attacker.resetAttempts
            _attempts = 0
        End Sub

        ' Class Properties
        ' Total Attempts on current hash.
        Public ReadOnly Property Attempts As Long Implements Attacker.Attempts
            Get
                Return _attempts
            End Get
        End Property

        ' Charset property
        Public Property Charset As String
            Get
                Return _charset
            End Get
            Set(value As String)
                _charset = value
            End Set
        End Property

        ' Minimum Property
        Public Property Minimum As Integer
            Get
                Return _minimum
            End Get
            Set(value As Integer)
                _minimum = value
            End Set
        End Property

        ' Maximum Property
        Public Property Maximum As Integer
            Get
                Return _maximum
            End Get
            Set(value As Integer)
                _maximum = value
            End Set
        End Property

        ' Determines whether the attacker should continue or not.
        Public WriteOnly Property Run As Boolean Implements Attacker.Run
            Set(value As Boolean)
                _run = value
            End Set
        End Property

        ' Total combinations due to current set brute force options.
        Public ReadOnly Property TotalCombinations As Long
            Get
                Try
                    Return Math.Pow(_charset.Length, _maximum)
                Catch ex As OverflowException
                    Return Long.MaxValue
                End Try
            End Get
        End Property
    End Class


    ' Contains tools used for dictionary attacks on password hashes.
    Public Class Dictionary : Implements Attacker
        Private _listPath As String
        Private _attempts As Integer
        Private _run As Boolean

        Public Sub New(ByVal listPath As String)
            Me.ListPath = listPath
        End Sub

        ' Starts the dictionary attack process.
        ' WARNING: May return null
        Public Function attack(ByVal hash As Hash) As String Implements Attacker.attack
            Dim sr As New StreamReader(_listPath)
            Dim password As String
            _run = True

            Do
                _attempts += 1
                password = sr.ReadLine()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password & hash.Salt)
                Dim hashBytes As Byte() = hash.Type.ComputeHash(bytes)
                If Convert.ToBase64String(hashBytes) = hash.Hash Then
                    Return password
                ElseIf Not _run Then
                    Return Nothing
                End If
            Loop Until password Is Nothing
            sr.Close()

            Return Nothing
        End Function

        Public Sub resetAttempts() Implements Attacker.resetAttempts
            _attempts = 0
        End Sub

        ' Class Properties
        ' Password List Path
        Public Property ListPath As String
            Get
                Return _listPath
            End Get
            Set(value As String)
                _listPath = value
            End Set
        End Property

        ' Total Attempts on current hash.
        Public ReadOnly Property Attempts As Long Implements Attacker.Attempts
            Get
                Return _attempts
            End Get
        End Property

        ' Determines whether the attacker should continue or not.
        Public WriteOnly Property Run As Boolean Implements Attacker.Run
            Set(value As Boolean)
                _run = value
            End Set
        End Property
    End Class

    Public Class HashFileParser
        Private _filePath As String
        Private reader As StreamReader

        Public Sub New(ByVal filePath As String)
            If Path.GetExtension(filePath) = ".hash" Then
                Me.FilePath = filePath
                reader = New StreamReader(filePath)
            Else
                Throw New ArgumentOutOfRangeException("File Must Be .hash Format")
            End If
        End Sub

        ' Generates a hash type that was read and parsed from the given file path.
        Public Iterator Function readHash() As IEnumerable(Of Hash)
            Do Until reader.Peek = -1
                Dim properties = parseHash(reader.ReadLine())
                Dim hashAlgorithm = determineAlgorithm(properties(2))
                Yield New Hash(properties(0), properties(1), hashAlgorithm)
            Loop
        End Function

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

        ' Parses line from hash file into three properties of a hash.
        ' TODO: Update this to use regular expressions. BUG, doesnt only remove the first occurances.
        Public Function parseHash(ByVal line As String) As List(Of String)
            Return line.Replace("Hash:", "").Replace("Salt:", "").Replace("HashType:", "").Replace(" ", "").Split(",").ToList()
        End Function

        ' Class Properties
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
    End Class
End Module
