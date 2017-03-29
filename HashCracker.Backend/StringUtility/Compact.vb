Imports System.Text
Namespace StringUtility
    ' Contains tools for compacting strings down to smaller yet still readable strings.
    Public Class Compact
#Region "Methods"
        ' Compresses a paths directories down to 4 directories by default or a chosen ammount.
        ' Length is the number of directories shown before the compression and current directory.
        Public Shared Function compactPath(ByVal path As String, Optional length As Integer = 2) As String
            Dim builder As New StringBuilder
            Dim dir = Split(path, "\")

            If dir.Count <= length Then
                Return path
            End If

            For index As Integer = 0 To length
                builder.Append(String.Format("{0}\", dir.ElementAt(index)))
            Next
            builder.Append("...\")
            builder.Append(dir.ElementAt(dir.Count() - 1))

            Return builder.ToString
        End Function
#End Region
    End Class
End Namespace