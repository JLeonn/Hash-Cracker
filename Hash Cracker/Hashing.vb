Imports System.Security.Cryptography
Imports System.Text

Public Module Hashing
    ' Contains tools used to hash a string with a given Hashing Algorithm.
    Public Class Hasher
        Private _algorithm As HashAlgorithm
        Private _useSalt As Boolean = True
        Private _salt As String = String.Empty

        Public Sub New(ByVal algorithm As HashAlgorithm)
            Me.algorithm = algorithm
        End Sub

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

        ' Class Properties
        ' The algorithm that will be used to hash.
        Public Property Algorithm As HashAlgorithm
            Get
                Return _algorithm
            End Get
            Set(value As HashAlgorithm)
                _algorithm = value
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

        ' The salt that will be applied along with the password to form the hash.
        Public Property Salt As String
            Get
                Return _salt
            End Get
            Set(value As String)
                _salt = value
            End Set
        End Property
    End Class


    ' Holds information regarding a hash.
    Public Class Hash
        Private _hash As String
        Private _salt As String
        Private _type As HashAlgorithm

        Public Sub New(ByVal hash As String, salt As String, type As HashAlgorithm)
            Me.Hash = hash
            Me.salt = salt
            Me.Type = type
        End Sub

        ' Class Properties
        ' The hash.
        Public Property Hash As String
            Get
                Return _hash
            End Get
            Set(value As String)
                _hash = value
            End Set
        End Property

        ' The salt that was used before hashing.
        Public Property Salt As String
            Get
                Return _salt
            End Get
            Set(value As String)
                _salt = value
            End Set
        End Property

        ' The hashing algorithm that was use to generate the hash.
        Public Property Type As HashAlgorithm
            Get
                Return _type
            End Get
            Set(value As HashAlgorithm)
                _type = value
            End Set
        End Property
    End Class
End Module
