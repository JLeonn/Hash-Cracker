Imports System.IO


Public Class OptionsForm
    Private _parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
    Private _savedChanges As Boolean

    ' Settings
    Private charset As String
    Private maximum As Integer
    Private minimum As Integer
    Private passwordListPath As String
    Private storagePath As String
    Private targetPath As String

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _savedChanges = False
        loadSettings()
    End Sub

    Private Sub buildCharsetButton_Click(sender As Object, e As EventArgs) Handles buildCharsetButton.Click
        CustomCharsetForm.ShowDialog()
        If CustomCharsetForm.Charset <> String.Empty Then
            charset = CustomCharsetForm.Charset
            charsetLabel.Text = CustomCharsetForm.Charset
        Else
            charset = String.Empty
            charsetLabel.Text = "No Built Charset."
        End If
    End Sub

    ' Displays the currently selected settings on the main form.
    ' Loads settings into memory.
    Private Sub loadSettings()
        If File.Exists(My.Settings.TargetPath) Then
            targetLabel.Text = Compact.compactPath(My.Settings.TargetPath)
            toolTip.SetToolTip(targetLabel, My.Settings.TargetPath)
            targetPath = My.Settings.TargetPath
        Else
            targetLabel.Text = "No Default Target Path Selected."
        End If

        If File.Exists(My.Settings.StoragePath) Then
            storageLabel.Text = Compact.compactPath(My.Settings.StoragePath)
            toolTip.SetToolTip(storageLabel, My.Settings.StoragePath)
            storagePath = My.Settings.StoragePath
        Else
            storageLabel.Text = "No Default Storage Path Selected."
        End If

        If My.Settings.Charset <> String.Empty Then
            charsetLabel.Text = My.Settings.Charset
            charset = My.Settings.Charset
        Else
            charset = String.Empty
            charsetLabel.Text = "No Default Charset Built."
        End If

        If File.Exists(My.Settings.PasswordPath) Then
            passwordListLabel.Text = Compact.compactPath(My.Settings.PasswordPath)
            toolTip.SetToolTip(passwordListLabel, My.Settings.PasswordPath)
            passwordListPath = My.Settings.PasswordPath
        Else
            passwordListLabel.Text = "No Default Password List Path Selected."
        End If

        maximumTextBox.Text = My.Settings.BruteForceMax
        maximum = My.Settings.BruteForceMax

        minimumTextBox.Text = My.Settings.BruteForceMin
        minimum = My.Settings.BruteForceMin
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Resets Variables
        targetPath = String.Empty
        storagePath = String.Empty
        passwordListPath = String.Empty
        charset = String.Empty
        minimum = 1
        maximum = 8

        ' Resets Visuals
        targetLabel.Text = "No Deafult Target Path Selected."
        storageLabel.Text = "No Deafult Storage Path Selected."
        charsetLabel.Text = "No Default Charset Built."
        passwordListLabel.Text = "No Deafult Password List Path Selected."
        minimumTextBox.Text = 1
        maximumTextBox.Text = 8
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub maximumTextBox_TextChanged(sender As Object, e As EventArgs) Handles maximumTextBox.Leave
        If Not (Integer.TryParse(maximumTextBox.Text, Nothing) And maximumTextBox.Text >= minimumTextBox.Text) Then
            MessageBox.Show("Invalid Maximum")
            maximumTextBox.Text = My.Settings.BruteForceMax
            Exit Sub
        End If

        maximum = maximumTextBox.Text
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub minimumTextBox_TextChanged(sender As Object, e As EventArgs) Handles minimumTextBox.Leave
        If Not (Integer.TryParse(minimumTextBox.Text, Nothing) And minimumTextBox.Text <= maximumTextBox.Text) Then
            MessageBox.Show("Invalid Minimum")
            minimumTextBox.Text = My.Settings.BruteForceMin
            Exit Sub
        End If

        minimum = minimumTextBox.Text
    End Sub

    ' Saves all option settings to application settings.
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        saveSettings()
        _savedChanges = True
        Close()
    End Sub

    Private Sub saveSettings()
        ' TargetPath
        If File.Exists(targetPath) Then
            My.Settings.TargetPath = targetPath
        Else
            My.Settings.TargetPath = String.Empty
        End If

        ' StoragePath
        If File.Exists(storagePath) Then
            My.Settings.StoragePath = storagePath
        Else
            My.Settings.StoragePath = String.Empty
        End If

        ' Charset
        If charset <> String.Empty Then
            My.Settings.Charset = charset
        Else
            My.Settings.Charset = String.Empty
        End If

        ' PasswordPath
        If File.Exists(passwordListPath) Then
            My.Settings.PasswordPath = passwordListPath
        Else
            My.Settings.PasswordPath = String.Empty
        End If

        My.Settings.BruteForceMin = minimumTextBox.Text
        My.Settings.BruteForceMax = maximumTextBox.Text
        My.Settings.Save()
    End Sub

    Private Sub storageButton_Click(sender As Object, e As EventArgs) Handles storageButton.Click
        openStorageFileDialog.InitialDirectory = _parentDirectory
        openStorageFileDialog.Filter = "Text File (.txt)|*.txt"
        openStorageFileDialog.ShowDialog()

        If File.Exists(openStorageFileDialog.FileName) Then
            storageLabel.Text = Compact.compactPath(openStorageFileDialog.FileName)
            toolTip.SetToolTip(storageLabel, openStorageFileDialog.FileName)
            storagePath = openStorageFileDialog.FileName
        Else
            storageLabel.Text = "No Deafult Storage Path Selected."
        End If
    End Sub

    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openTargetFileDialog.InitialDirectory = _parentDirectory
        openTargetFileDialog.Filter = "Hash File (.hash)|*.hash"
        openTargetFileDialog.ShowDialog()

        If File.Exists(openTargetFileDialog.FileName) And Path.GetExtension(openTargetFileDialog.FileName) = ".hash" Then
            targetLabel.Text = Compact.compactPath(openTargetFileDialog.FileName)
            toolTip.SetToolTip(targetLabel, openTargetFileDialog.FileName)
            targetPath = openTargetFileDialog.FileName
        Else
            targetLabel.Text = "No Deafult Target Path Selected."
        End If
    End Sub

    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        openPasswordFileDialog.InitialDirectory = _parentDirectory
        openPasswordFileDialog.Filter = "Text File (.txt)|*.txt"
        openPasswordFileDialog.ShowDialog()

        If File.Exists(openPasswordFileDialog.FileName) Then
            passwordListLabel.Text = Compact.compactPath(openPasswordFileDialog.FileName)
            toolTip.SetToolTip(passwordListLabel, openPasswordFileDialog.FileName)
            passwordListPath = openPasswordFileDialog.FileName
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