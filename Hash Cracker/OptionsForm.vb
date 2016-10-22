Imports System.IO


Public Class OptionsForm
    Private parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()

    Private _savedChanges As Boolean

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _savedChanges = False
        displaySettings()
    End Sub

    Private Sub buildCharsetButton_Click(sender As Object, e As EventArgs) Handles buildCharsetButton.Click
        CustomCharsetForm.ShowDialog()
        If CustomCharsetForm.Charset = String.Empty Then
            My.Settings.Charset = String.Empty
            charsetLabel.Text = "No Built Charset."
        Else
            My.Settings.Charset = CustomCharsetForm.Charset
            charsetLabel.Text = CustomCharsetForm.Charset
        End If
    End Sub

    ' Displays the currently selected settings on the main form.
    Private Sub displaySettings()
        ' TargetPath
        If File.Exists(My.Settings.TargetPath) Then
            targetLabel.Text = Compact.compactPath(My.Settings.TargetPath)
            toolTip.SetToolTip(targetLabel, My.Settings.TargetPath)
        Else
            targetLabel.Text = "No Deafult Target Path Selected."
        End If

        ' StoragePath
        If File.Exists(My.Settings.StoragePath) Then
            storageLabel.Text = Compact.compactPath(My.Settings.StoragePath)
            toolTip.SetToolTip(storageLabel, My.Settings.StoragePath)
        Else
            storageLabel.Text = "No Deafult Storage Path Selected."
        End If

        ' Charset
        If My.Settings.Charset = String.Empty Then
            charsetLabel.Text = "No Deafult Charset Built."
        Else
            charsetLabel.Text = My.Settings.Charset
        End If

        ' PasswordPath
        If File.Exists(My.Settings.PasswordPath) Then
            passwordListLabel.Text = Compact.compactPath(My.Settings.PasswordPath)
            toolTip.SetToolTip(passwordListLabel, My.Settings.PasswordPath)
        Else
            passwordListLabel.Text = "No Deafult Password List Path Selected."
        End If

        minimumTextBox.Text = My.Settings.BruteForceMin
        maximumTextBox.Text = My.Settings.BruteForceMax
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        targetLabel.Text = "No Deafult Target Path Selected."
        storageLabel.Text = "No Deafult Storage Path Selected."
        charsetLabel.Text = "No Deafult Charset Built."
        passwordListLabel.Text = "No Deafult Password List Path Selected."
        minimumTextBox.Text = 1
        maximumTextBox.Text = 8
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub maximumTextBox_TextChanged(sender As Object, e As EventArgs) Handles maximumTextBox.Leave
        If Not (Integer.TryParse(maximumTextBox.Text, Nothing) And maximumTextBox.Text > minimumTextBox.Text) Then
            MessageBox.Show("Invalid Maximum")
            maximumTextBox.Text = My.Settings.BruteForceMax
        End If
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub minimumTextBox_TextChanged(sender As Object, e As EventArgs) Handles minimumTextBox.Leave
        If Not (Integer.TryParse(minimumTextBox.Text, Nothing) And minimumTextBox.Text < maximumTextBox.Text) Then
            MessageBox.Show("Invalid Minimum")
            minimumTextBox.Text = My.Settings.BruteForceMin
        End If
    End Sub

    ' Saves all option settings to application settings.
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        My.Settings.TargetPath = targetLabel.Text
        My.Settings.StoragePath = storageLabel.Text
        My.Settings.Charset = charsetLabel.Text
        My.Settings.PasswordPath = passwordListLabel.Text
        My.Settings.BruteForceMin = minimumTextBox.Text
        My.Settings.BruteForceMax = maximumTextBox.Text

        My.Settings.Save()
        _savedChanges = True
        Close()
    End Sub

    Private Sub storageButton_Click(sender As Object, e As EventArgs) Handles storageButton.Click
        openStorageFileDialog.InitialDirectory = parentDirectory
        openStorageFileDialog.Filter = "Text File (.txt)|*.txt"
        openStorageFileDialog.ShowDialog()

        If File.Exists(openStorageFileDialog.FileName) Then
            storageLabel.Text = Compact.compactPath(openStorageFileDialog.FileName)
            toolTip.SetToolTip(storageLabel, openStorageFileDialog.FileName)
        Else
            storageLabel.Text = "No Deafult Storage Path Selected."
        End If
    End Sub

    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openTargetFileDialog.InitialDirectory = parentDirectory
        openTargetFileDialog.Filter = "Hash File (.hash)|*.hash"
        openTargetFileDialog.ShowDialog()

        If File.Exists(openTargetFileDialog.FileName) And Path.GetExtension(openTargetFileDialog.FileName) = ".hash" Then
            targetLabel.Text = Compact.compactPath(openTargetFileDialog.FileName)
            toolTip.SetToolTip(targetLabel, openTargetFileDialog.FileName)
        Else
            targetLabel.Text = "No Deafult Target Path Selected."
        End If
    End Sub

    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        openPasswordFileDialog.InitialDirectory = parentDirectory
        openPasswordFileDialog.Filter = "Text File (.txt)|*.txt"
        openPasswordFileDialog.ShowDialog()

        If File.Exists(openPasswordFileDialog.FileName) Then
            passwordListLabel.Text = Compact.compactPath(openPasswordFileDialog.FileName)
            toolTip.SetToolTip(passwordListLabel, openPasswordFileDialog.FileName)
        Else
            storageLabel.Text = "No Deafult Password List Path Selected."
        End If
    End Sub

    ' Class Properties
    Public ReadOnly Property SavedChanges As Boolean
        Get
            Return _savedChanges
        End Get
    End Property
End Class