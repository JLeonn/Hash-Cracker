Imports System.Text

Public Class PathCompactor
    Private _path As String

    Public Sub New(ByVal path As String)
        _path = path
    End Sub

    Public Function compact(Optional length As Integer = 2) As String
        Dim builder As New StringBuilder
        Dim dir = Split(_path, "\")

        If dir.Count <= length Then
            Return _path
        End If

        For index As Integer = 0 To length
            builder.Append(String.Format("{0}\", dir.ElementAt(index)))
        Next
        builder.Append("...\")
        builder.Append(dir.ElementAt(dir.Count() - 1))

        Return builder.ToString
    End Function

    ' Class Properties
    Public Property Path
        Get
            Return _path
        End Get
        Set(value)
            _path = value
        End Set
    End Property
End Class
