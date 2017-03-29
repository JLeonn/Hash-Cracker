Imports HashCracker.Backend.StringUtility
Imports System.Security.Cryptography
Imports System.Text

Namespace Hashing
    Public Class Hasher
#Region "Fields"
        Private _algorithm As HashAlgorithm
        Private _salt As String = String.Empty
        Private _useSalt As Boolean = True
#End Region

#Region "Constructors"
        Public Sub New(ByVal algorithm As HashAlgorithm)
            Me.Algorithm = algorithm
        End Sub
#End Region

#Region "Methods"
        ' Hashes given password with wanted algorithm and salt if wanted.
        ' Default salt size is 20 characters.
        Public Function hash(ByVal password As String, Optional saltSize As Integer = 19) As Hash
            Dim salt As String

            If Not _useSalt Then
                salt = String.Empty
            Else
                salt = generateSalt(saltSize)
            End If

            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
            Dim hashBytes As Byte() = Algorithm.ComputeHash(bytes)
            Return New Hash(Convert.ToBase64String(hashBytes), salt, Algorithm)
        End Function

        ' Generates salt with the desired length.
        Public Function generateSalt(ByVal saltSize As Integer) As String
            Dim salt As New StringBuilder
            Dim random As New Random()

            For i As Integer = 0 To saltSize
                Dim randomIndex As Integer = random.Next(0, ALL_CHARACTERS.Length - 1)
                salt.Append(ALL_CHARACTERS.Substring(randomIndex, 1))
            Next
            Return salt.ToString()
        End Function
#End Region

#Region "Properties"
        ' The algorithm that will be used to hash.
        Public Property Algorithm As HashAlgorithm
            Get
                Return _algorithm
            End Get
            Set(value As HashAlgorithm)
                _algorithm = value
            End Set
        End Property

        ' The salt that will be applied along with the password to form the hash.
        Public Property Salt As String
            Get
                Return _salt
            End Get
            Set(value As String)
                _salt = value
            End Set
        End Property

        ' Determines if a salt should be used or not.
        Public Property UseSalt As Boolean
            Get
                Return _useSalt
            End Get
            Set(value As Boolean)
                _useSalt = value
            End Set
        End Property
#End Region
    End Class
End Namespace