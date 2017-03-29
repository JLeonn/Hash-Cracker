Imports System.Security.Cryptography

Namespace Hashing
    ' Holds information regarding a hash. The result of a string being hashed.
    Public Class Hash
#Region "Fields"
        Private _hash As String
        Private _salt As String
        Private _type As HashAlgorithm
#End Region

#Region "Constructors"
        Public Sub New(ByVal hash As String, salt As String, type As HashAlgorithm)
            Me.Hash = hash
            Me.Salt = salt
            Me.Type = type
        End Sub
#End Region

#Region "Properties"
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
#End Region
    End Class

End Namespace