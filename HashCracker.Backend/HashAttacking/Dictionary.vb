Imports HashCracker.Backend.Hashing
Imports System.IO
Imports System.Text

Namespace HashAttacking
    ' Contains tools used for dictionary attacks on password hashes.
    Public Class Dictionary : Implements Attacker
#Region "Fields"
        Private _attempts As Integer
        Private _listPath As String
        Private _run As Boolean
#End Region

#Region "Constructors"
        Public Sub New(ByVal listPath As String)
            Me.ListPath = listPath
        End Sub
#End Region

#Region "Methods"
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
#End Region

#Region "Properties"
        ' Total Attempts on current hash.
        Public ReadOnly Property Attempts As Long Implements Attacker.Attempts
            Get
                Return _attempts
            End Get
        End Property

        ' Password List Path
        Public Property ListPath As String
            Get
                Return _listPath
            End Get
            Set(value As String)
                _listPath = value
            End Set
        End Property

        ' Determines whether the attacker should continue or not.
        Public WriteOnly Property Run As Boolean Implements Attacker.Run
            Set(value As Boolean)
                _run = value
            End Set
        End Property
#End Region
    End Class
End Namespace

