Imports HashCracker.Backend.Hashing
Imports System.Text

Namespace HashAttacking
    ' Contains tools used to perform brute force attacks on password hashes.
    Public Class BruteForce : Implements Attacker
#Region "Fields"
        Private _attempts As Integer
        Private _charset As String
        Private _minimum As Integer
        Private _maximum As Integer
        Private _run As Boolean
#End Region

#Region "Constructors"
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
#End Region

#Region "Methods"
        ' Starts the bruteforce cracking process.
        ' WARNING: May return null
        Public Function attack(ByVal hash As Hash) As String Implements Attacker.attack
            _run = True
            Dim passwords As IEnumerable(Of String) = generatePasswords()

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

        ' Calculates the number of possible combinations and starts generating all of them.
        Private Iterator Function generatePasswords() As IEnumerable(Of String)
            For min As Integer = _minimum To _maximum
                Dim total As Long = Math.Pow(Charset.Length, min)
                Dim counter As Long = 0
                While counter < total
                    Yield factoradic(counter, min - 1)
                    counter += 1
                End While
            Next
        End Function

        Public Sub resetAttempts() Implements Attacker.resetAttempts
            _attempts = 0
        End Sub
#End Region

#Region "Properties"
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

        ' Maximum Property
        Public Property Maximum As Integer
            Get
                Return _maximum
            End Get
            Set(value As Integer)
                _maximum = value
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

        ' Determines whether the attacker should continue or not.
        Public WriteOnly Property Run As Boolean Implements Attacker.Run
            Set(value As Boolean)
                _run = value
            End Set
        End Property

        ' Total combinations due to current set brute force options.
        ' TODO: 
        Public ReadOnly Property TotalCombinations As Long
            Get
                Try
                    Return Math.Pow(_charset.Length, _maximum)
                Catch ex As OverflowException
                    Return Long.MaxValue
                End Try
            End Get
        End Property
#End Region
    End Class
End Namespace