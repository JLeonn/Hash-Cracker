Imports System.IO
Imports System.Threading
Imports HashCracker.Backend.HashAttacking
Imports HashCracker.Backend.StringUtility

' Backend for the mainform
Public Class MainForm
#Region "Fields"
    Private _attackManager As AttackManager
    Private _attackMethod As String
    Private _charset As String
    Private _elapsedTime As Integer
    Private _maximum As Integer
    Private _minimum As Integer
    Private _parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
    Private _passwordListPath As String
    Private _statThread As Thread
    Private _storagePath As String
    Private _targetPath As String
#End Region

#Region "Handlers"
    ' On Load
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        loadSettings()
    End Sub

    Private Sub bruteforceRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles bruteforceRadioButton.CheckedChanged
        setOptions(False, True)
    End Sub

    ' Starts custom charset form and sets the result to the main form
    ' Seperate from application settings
    Private Sub buildCharsetButton_Click(sender As Object, e As EventArgs) Handles buildCharsetButton.Click
        CustomCharsetForm.ShowDialog()
        If CustomCharsetForm.Charset <> String.Empty Then
            _charset = CustomCharsetForm.Charset
            My.Settings.Charset = CustomCharsetForm.Charset
            charsetLabel.Text = CustomCharsetForm.Charset
        Else
            _charset = String.Empty
            My.Settings.Charset = String.Empty
            charsetLabel.Text = "No Built Charset."
        End If
    End Sub

    Private Sub dictionaryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles dictionaryRadioButton.CheckedChanged
        setOptions(True, False)
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub maximumTextBox_TextChanged(sender As Object, e As EventArgs) Handles maximumTextBox.Leave
        If Integer.TryParse(maximumTextBox.Text, Nothing) And maximumTextBox.Text >= minimumTextBox.Text Then
            _maximum = maximumTextBox.Text
            My.Settings.BruteForceMax = maximumTextBox.Text
        Else
            MessageBox.Show("Invalid Maximum")
            maximumTextBox.Text = My.Settings.BruteForceMax
        End If
    End Sub

    ' Checks whether the changed text is valid.
    Private Sub minimumTextBox_TextChanged(sender As Object, e As EventArgs) Handles minimumTextBox.Leave
        If Integer.TryParse(minimumTextBox.Text, Nothing) And minimumTextBox.Text <= maximumTextBox.Text Then
            _minimum = minimumTextBox.Text
            My.Settings.BruteForceMin = minimumTextBox.Text
        Else
            MessageBox.Show("Invalid Minimum")
            minimumTextBox.Text = My.Settings.BruteForceMin
        End If
    End Sub

    ' Prompts use to select a password list.
    ' Seperate from application settings.
    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        openPasswordFileDialog.InitialDirectory = _parentDirectory
        openPasswordFileDialog.Multiselect = False
        openPasswordFileDialog.Filter = "Text File (.txt)|*.txt"
        openPasswordFileDialog.ShowDialog()

        If File.Exists(openPasswordFileDialog.FileName) Then
            passwordListLabel.Text = Compact.compactPath(openPasswordFileDialog.FileName)
            toolTip.SetToolTip(passwordListLabel, openPasswordFileDialog.FileName)
            _passwordListPath = openPasswordFileDialog.FileName
            My.Settings.PasswordPath = openPasswordFileDialog.FileName
        End If
    End Sub

    ' Initiates the cracking process.
    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If statusLabel.Text = "Running" Then
            Exit Sub
        End If

        If _targetPath = Nothing Then
            MessageBox.Show("No Target Path Selected.")
            Exit Sub
        End If

        If _storagePath = Nothing Then
            MessageBox.Show("No Storage Path Selected.")
            Exit Sub
        End If

        _attackManager = New AttackManager(_targetPath, _storagePath)
        Select Case _attackMethod
            Case "bruteforce"
                '  Checks information needed to commence a bruteforce attack.
                If _charset = String.Empty Then
                    MessageBox.Show("No Charset Was Given.")
                    Exit Sub
                End If

                ' Attacks the given hash file while still giving the user usability of the interface.
                Dim attacker As New BruteForce(_charset, _minimum, _maximum)
                _attackManager.Attacker = attacker
                totalPossibleLabel.Enabled = True
                totalPossibleLabel.Text = attacker.TotalCombinations.ToString("N0")
            Case "dictionary"
                ' Checks information need to commence a dictinary attack
                If _passwordListPath = Nothing Then
                    MessageBox.Show("No Password List Selected.")
                    Exit Sub
                End If

                Dim attacker As New Dictionary(_passwordListPath)
                _attackManager.Attacker = attacker
                totalPossibleLabel.Text = String.Empty
                totalPossibleLabel.Enabled = False
            Case Else
                MessageBox.Show("No Attack Method Was Chosen.")
                Exit Sub
        End Select
        ' Re-Initializes intface visuals
        timer.Enabled = True
        statusLabel.Text = "Running"
        elapsedTimeLabel.Text = "00:00:00"
        _elapsedTime = 0
        attemptsPerSecondLabel.Text = 0

        ' Starts the attack manager, statistic manager and timer.
        _attackManager.start()
        _statThread = New Thread(New ThreadStart(AddressOf updateStats))
        _statThread.Start()
        timer.Start()
    End Sub

    ' Seperate from application settings.
    Private Sub storageButton_Click(sender As Object, e As EventArgs) Handles storageButton.Click
        openStorageFileDialog.InitialDirectory = _parentDirectory
        openStorageFileDialog.Filter = "Text File (.txt)|*.txt"
        openStorageFileDialog.ShowDialog()

        If File.Exists(openStorageFileDialog.FileName) Then
            storageLabel.Text = Compact.compactPath(openStorageFileDialog.FileName)
            toolTip.SetToolTip(storageLabel, openStorageFileDialog.FileName)
            _storagePath = openStorageFileDialog.FileName
            My.Settings.StoragePath = openStorageFileDialog.FileName
        End If
    End Sub

    ' Updates visuals
    ' Haults the attack manager
    ' Stops the timer.
    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        If statusLabel.Text = "Running" Then
            statusLabel.Text = "Stopped"
            _attackManager.hault()
            timer.Enabled = False
        End If
    End Sub

    ' Seperate from application settings.
    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openTargetFileDialog.InitialDirectory = _parentDirectory
        openTargetFileDialog.Filter = "Hash File (.hash)|*.hash"
        openTargetFileDialog.ShowDialog()

        If File.Exists(openTargetFileDialog.FileName) Then
            targetLabel.Text = Compact.compactPath(openTargetFileDialog.FileName)
            toolTip.SetToolTip(targetLabel, openTargetFileDialog.FileName)
            _targetPath = openTargetFileDialog.FileName
            My.Settings.TargetPath = openTargetFileDialog.FileName
        End If
    End Sub

    ' Every tick updates the timer and
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        _elapsedTime += 1
        Dim time = TimeSpan.FromSeconds(_elapsedTime)
        elapsedTimeLabel.Text = time.ToString("hh\:mm\:ss")
        attemptsPerSecondLabel.Text = Math.Round(currentAttemptsLabel.Text / _elapsedTime, 2).ToString("N2")
    End Sub
#End Region

#Region "Methods"
    ' Displays the currently selected settings on the main form.
    ' Loads settings into memory.
    Private Sub loadSettings()
        If File.Exists(My.Settings.TargetPath) Then
            targetLabel.Text = Compact.compactPath(My.Settings.TargetPath)
            toolTip.SetToolTip(targetLabel, My.Settings.TargetPath)
            _targetPath = My.Settings.TargetPath
        Else
            targetLabel.Text = "No Target Path Selected."
        End If

        If File.Exists(My.Settings.StoragePath) Then
            storageLabel.Text = Compact.compactPath(My.Settings.StoragePath)
            toolTip.SetToolTip(storageLabel, My.Settings.StoragePath)
            _storagePath = My.Settings.StoragePath
        Else
            storageLabel.Text = "No Storage Path Selected."
        End If

        If File.Exists(My.Settings.PasswordPath) Then
            passwordListLabel.Text = Compact.compactPath(My.Settings.PasswordPath)
            toolTip.SetToolTip(passwordListLabel, My.Settings.PasswordPath)
            _passwordListPath = My.Settings.PasswordPath
        Else
            passwordListLabel.Text = "No Password List Path Selected."
        End If

        If My.Settings.Charset <> String.Empty Then
            charsetLabel.Text = My.Settings.Charset
            _charset = My.Settings.Charset
        Else
            _charset = String.Empty
            charsetLabel.Text = "No Charset Built."
        End If

        maximumTextBox.Text = My.Settings.BruteForceMax
        _maximum = My.Settings.BruteForceMax

        minimumTextBox.Text = My.Settings.BruteForceMin
        _minimum = My.Settings.BruteForceMin
    End Sub

    'Thread safe delegate sub used to update label text properties on different threads.
    Private Delegate Sub SetTextCallBack([text] As String, label As Label)

    ' Flips the attack option between the bruteforce and dictionary attack.
    Private Sub setOptions(ByVal dictionaryOption As Boolean, bruteForceOption As Boolean)
        ' Sets the attak accordingly
        If dictionaryOption Then
            _attackMethod = "dictionary"
        Else
            _attackMethod = "bruteforce"
        End If

        ' Dictionary options
        passwordListButton.Enabled = dictionaryOption
        passwordListLabel.Enabled = dictionaryOption

        ' Bruteforce options
        buildCharsetButton.Enabled = bruteForceOption
        charsetLabel.Enabled = bruteForceOption
        minimumTextBox.Enabled = bruteForceOption
        maximumTextBox.Enabled = bruteForceOption
    End Sub

    ' Thread safe function used to update Labels on a different thread.
    ' Used in conjunction with 'updateStats'
    Private Sub updateLabel(ByVal [text] As String, label As Label)
        If label.InvokeRequired Then
            Dim d As New SetTextCallBack(AddressOf updateLabel)
            Invoke(d, New Object() {[text], label})
        Else
            label.Text = [text]
        End If
    End Sub

    ' The threaded action that maintains the statistal tab.
    Public Sub updateStats()
        While _attackManager.Running
            updateLabel(_attackManager.HashesCracked, hashesBrokeLabel)
            updateLabel(_attackManager.Attacker.Attempts.ToString("N0"), currentAttemptsLabel)
        End While

        updateLabel("Stopped", statusLabel)
        timer.Enabled = False
    End Sub
#End Region
End Class