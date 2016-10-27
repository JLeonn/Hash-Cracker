Imports System.IO


Public Class OptionsForm
    Private _parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
    Private _savedChanges As Boolean

    ' Settings
    Private _charset As String
    Private _maximum As Integer
    Private _minimum As Integer
    Private _passwordListPath As String
    Private _storagePath As String
    Private _targetPath As String

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _savedChanges = False
        loadSettings()
    End Sub

    Private Sub buildCharsetButton_Click(sender As Object, e As EventArgs) Handles buildCharsetButton.Click
        CustomCharsetForm.ShowDialog()
        If CustomCharsetForm.Charset <> String.Empty Then
            _charset = CustomCharsetForm.Charset
            charsetLabel.Text = CustomCharsetForm.Charset
        Else
            _charset = String.Empty
            charsetLabel.Text = "No Default Built Charset."
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Resets Variables
        _targetPath = String.Empty
        _storagePath = String.Empty
        _passwordListPath = String.Empty
        _charset = String.Empty
        _minimum = 1
        _maximum = 8

        ' Resets Visuals
        targetLabel.Text = "No Deafult Target Path Selected."
        storageLabel.Text = "No Deafult Storage Path Selected."
        charsetLabel.Text = "No Default Charset Built."
        passwordListLabel.Text = "No Deafult Password List Path Selected."
        minimumTextBox.Text = 1
        maximumTextBox.Text = 8
    End Sub

    ' Displays the currently selected settings on the main form.
    ' Loads settings into memory.
    Private Sub loadSettings()
        If File.Exists(My.Settings.TargetPath) Then
            targetLabel.Text = Compact.compactPath(My.Settings.TargetPath)
            toolTip.SetToolTip(targetLabel, My.Settings.TargetPath)
            _targetPath = My.Settings.TargetPath
        Else
            targetLabel.Text = "No Default Target Path Selected."
        End If

        If File.Exists(My.Settings.StoragePath) Then
            storageLabel.Text = Compact.compactPath(My.Settings.StoragePath)
            toolTip.SetToolTip(storageLabel, My.Settings.StoragePath)
            _storagePath = My.Settings.StoragePath
        Else
            storageLabel.Text = "No Default Storage Path Selected."
        End If

        If My.Settings.Charset <> String.Empty Then
            charsetLabel.Text = My.Settings.Charset
            _charset = My.Settings.Charset
        Else
            _charset = String.Empty
            charsetLabel.Text = "No Default Charset Built."
        End If

        If File.Exists(My.Settings.PasswordPath) Then
            passwordListLabel.Text = Compact.compactPath(My.Settings.PasswordPath)
            toolTip.SetToolTip(passwordListLabel, My.Settings.PasswordPath)
            _passwordListPath = My.Settings.PasswordPath
        Else
            passwordListLabel.Text = "No Default Password List Path Selected."
        End If

        maximumTextBox.Text = My.Settings.BruteForceMax
        _maximum = My.Settings.BruteForceMax

        minimumTextBox.Text = My.Settings.BruteForceMin
        _minimum = My.Settings.BruteForceMin
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub maximumTextBox_TextChanged(sender As Object, e As EventArgs) Handles maximumTextBox.Leave
        If Not (Integer.TryParse(maximumTextBox.Text, Nothing) And maximumTextBox.Text >= minimumTextBox.Text) Then
            MessageBox.Show("Invalid Maximum")
            maximumTextBox.Text = My.Settings.BruteForceMax
            Exit Sub
        End If

        _maximum = maximumTextBox.Text
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub minimumTextBox_TextChanged(sender As Object, e As EventArgs) Handles minimumTextBox.Leave
        If Not (Integer.TryParse(minimumTextBox.Text, Nothing) And minimumTextBox.Text <= maximumTextBox.Text) Then
            MessageBox.Show("Invalid Minimum")
            minimumTextBox.Text = My.Settings.BruteForceMin
            Exit Sub
        End If

        _minimum = minimumTextBox.Text
    End Sub

    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        openPasswordFileDialog.InitialDirectory = _parentDirectory
        openPasswordFileDialog.Filter = "Text File (.txt)|*.txt"
        openPasswordFileDialog.ShowDialog()

        If File.Exists(openPasswordFileDialog.FileName) Then
            passwordListLabel.Text = Compact.compactPath(openPasswordFileDialog.FileName)
            toolTip.SetToolTip(passwordListLabel, openPasswordFileDialog.FileName)
            _passwordListPath = openPasswordFileDialog.FileName
        Else
            storageLabel.Text = "No Deafult Password List Path Selected."
        End If
    End Sub

    ' Saves all option settings to application settings.
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        saveSettings()
        _savedChanges = True
        Close()
    End Sub

    Private Sub saveSettings()
        ' TargetPath
        If File.Exists(_targetPath) Then
            My.Settings.TargetPath = _targetPath
        Else
            My.Settings.TargetPath = String.Empty
        End If

        ' StoragePath
        If File.Exists(_storagePath) Then
            My.Settings.StoragePath = _storagePath
        Else
            My.Settings.StoragePath = String.Empty
        End If

        ' Charset
        If _charset <> String.Empty Then
            My.Settings.Charset = _charset
        Else
            My.Settings.Charset = String.Empty
        End If

        ' PasswordPath
        If File.Exists(_passwordListPath) Then
            My.Settings.PasswordPath = _passwordListPath
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
            _storagePath = openStorageFileDialog.FileName
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
            _targetPath = openTargetFileDialog.FileName
        Else
            targetLabel.Text = "No Deafult Target Path Selected."
        End If
    End Sub

    ' Class Properties
    Public ReadOnly Property SavedChanges As Boolean
        Get
            Return _savedChanges
        End Get
    End Property
End Class