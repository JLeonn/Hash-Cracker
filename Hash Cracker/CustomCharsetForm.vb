Public Class CustomCharsetForm
    Private _charset As String

    Private Sub setCharsetButton_Click(sender As Object, e As EventArgs) Handles setCharsetButton.Click
        _charset = textBox.Text
        Close()
    End Sub

    Public ReadOnly Property Charset As String
        Get
            Return _charset
        End Get
    End Property
End Class