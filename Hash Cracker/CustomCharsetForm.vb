Public Class CustomCharsetForm
    Private _charset As String

    Private Sub setCharsetButton_Click(sender As Object, e As EventArgs) Handles setCharsetButton.Click
        If findDuplicate(textBox.Text) Then
            Dim result = MsgBox("Duplicates In Charset. Continue?", MsgBoxStyle.YesNo, "Duplicates Detected")
            If result = MsgBoxResult.Yes Then
                _charset = textBox.Text
                Close()
            End If
        Else
            _charset = textBox.Text
            Close()
        End If
    End Sub

    Private Sub lowerCaseCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles lowerCaseCheckBox.CheckedChanged
        updateCharset(lowerCaseCheckBox, LOWER_CASES)
    End Sub

    Private Sub upperCaseCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles upperCaseCheckBox.CheckedChanged
        updateCharset(upperCaseCheckBox, UPPER_CASES)
    End Sub

    Private Sub numberCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles numberCheckBox.CheckedChanged
        updateCharset(numberCheckBox, NUMBERS)
    End Sub

    Private Sub symbolsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles symbolsCheckBox.CheckedChanged
        updateCharset(symbolsCheckBox, SYMBOLS)
    End Sub

    Private Sub spacesCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles spacesCheckBox.CheckedChanged
        updateCharset(spacesCheckBox, SPACES)
    End Sub

    ' Updates text box's charset deppending on which check boxes are checked.
    Private Sub updateCharset(ByVal checkBox As CheckBox, subCharset As String)
        If checkBox.Checked Then
            textBox.Text += subCharset
        Else
            textBox.Text = textBox.Text.Replace(subCharset, "")
        End If
    End Sub

    ' Determines if there are duplicate characters in a given string
    Private Function findDuplicate(ByVal charset As String) As Boolean
        Dim characters = charset.ToCharArray
        For i As Integer = 0 To characters.Count - 1
            For j As Integer = 0 To characters.Count - 1
                If i = j Then
                    Continue For
                ElseIf characters.ElementAt(i) = characters.ElementAt(j) Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    ' Class Properties
    Public ReadOnly Property Charset As String
        Get
            Return _charset
        End Get
    End Property
End Class