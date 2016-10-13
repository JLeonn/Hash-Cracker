Imports System.IO
Imports System.Text

' Module dedicated to cracking hashes.
' Current attacks: Bruteforce, Dictionary
Public Module HashCracking
    Public Interface Attacker
        ReadOnly Property Attempts As Long
        WriteOnly Property Run As Boolean
        Function attack(ByVal hash As Hash) As String
    End Interface


    ' Contains tools used to perform brute force attacks on password hashes.
    Public Class BruteForce : Implements Attacker
        Private _attempts As Integer
        Private _charset As String = ALL_CHARACTERS
        Private _length As Integer = Charset.Length()
        Private _minimum As Integer = 1
        Private _maximum As Integer = 10
        Private _run As Boolean

        Public Sub New()
            ' Pass
        End Sub

        Public Sub New(ByVal charset As String)
            Me.Charset = charset
            _length = charset.Length
        End Sub

        Public Sub New(ByVal minimum As Integer, maximum As Integer)
            Me.Minimum = minimum
            Me.Maximum = maximum
        End Sub

        Public Sub New(ByVal charset As String, minimum As Integer, maximum As Integer)
            Me.Charset = charset
            _length = charset.Length()
            Me.Minimum = minimum
            Me.Maximum = maximum
        End Sub

        ' Starts the bruteforce cracking process.
        ' WARNING: May return null
        Public Function attack(ByVal hash As Hash) As String Implements Attacker.attack
            _attempts = 0
            _run = True
            Dim passwords As IEnumerable(Of String) = generatePasswords(Minimum, Maximum)
            For Each password As String In passwords
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
        Public Iterator Function generatePasswords(ByVal min As Integer, maximum As Integer) As IEnumerable(Of String)
            For _minimum = min To maximum
                Dim total As Long = Math.Pow(Charset.Length, _minimum)
                Dim counter As Long = 0
                While counter < total
                    Yield factoradic(counter, Minimum - 1)
                    counter += 1
                End While
            Next
        End Function

        ' Generates each possible combination with the given
        Private Function factoradic(ByVal l As Long, power As Double) As String
            Dim sb As New StringBuilder
            While power >= 0
                sb = sb.Append(Charset((l Mod _length)))
                l /= _length
                power -= 1
            End While
            Return sb.ToString
        End Function

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
                _length = value.Length
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
                Return Math.Pow(_charset.Length, _maximum)
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
            _attempts = 0
            _run = True

            Do
                _attempts += 1
                password = sr.ReadLine()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password & hash.Salt)
                Dim hashBytes As Byte() = hash.Type.ComputeHash(bytes)
                If Convert.ToBase64String(hashBytes) = hash.Hash Then
                    Return password
                ElseIf Not _run Then
                    Exit Do
                End If
            Loop Until password Is Nothing
            sr.Close()

            Return Nothing
        End Function

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
End Module
