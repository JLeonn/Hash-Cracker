Imports System.IO
Imports System.Text
Imports System.Threading

' Contains all the handlers for the main form.
Public Class MainForm
    Private parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
    Private defaultStoragePath = parentDirectory & "\Crack Session.txt"

    Private attackManager As AttackManager
    Private attackMethod As String
    Private compactor As PathCompactor
    Private elapsedTime As Integer
    Private passwordListPath As String
    Private statThread As Thread
    Private storagePath As String
    Private targetPath As String

    'Thread safe delegate sub used to update label text properties on different threads.
    Private Delegate Sub SetTextCallBack([text] As String, label As Label)

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        compactor = New PathCompactor(defaultStoragePath)
        storageLabel.Text = compactor.compact()
        toolTip.SetToolTip(storageLabel, defaultStoragePath)
        storagePath = defaultStoragePath
    End Sub

    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        openTargetFileDialog.InitialDirectory = parentDirectory
        openTargetFileDialog.Filter = "Hash File (.hash)|*.hash"
        openTargetFileDialog.ShowDialog()

        If File.Exists(openTargetFileDialog.FileName) And Path.GetExtension(openTargetFileDialog.FileName) = ".hash" Then
            compactor.Path = openTargetFileDialog.FileName
            targetLabel.Text = compactor.compact()
            toolTip.SetToolTip(targetLabel, openTargetFileDialog.FileName)
            targetPath = openTargetFileDialog.FileName
        Else
            targetLabel.Text = "No Target Selected."
        End If
    End Sub

    Private Sub storageButton_Click(sender As Object, e As EventArgs) Handles storageButton.Click
        openStorageFileDialog.InitialDirectory = parentDirectory
        openStorageFileDialog.Filter = "Text File (.txt)|*.txt"
        openStorageFileDialog.ShowDialog()

        If File.Exists(openStorageFileDialog.FileName) Then
            compactor.Path = openStorageFileDialog.FileName
            storageLabel.Text = compactor.compact()
            toolTip.SetToolTip(storageLabel, openStorageFileDialog.FileName)
            storagePath = openStorageFileDialog.FileName
        Else
            storageLabel.Text = "No Storage Path Selected."
            storagePath = defaultStoragePath
        End If
    End Sub

    Private Sub bruteforceRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles bruteforceRadioButton.CheckedChanged
        setOptions(False, True)
    End Sub

    Private Sub dictionaryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles dictionaryRadioButton.CheckedChanged
        setOptions(True, False)
    End Sub

    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        openPasswordFileDialog.InitialDirectory = parentDirectory
        openPasswordFileDialog.Filter = "Text File (.txt)|*.txt"
        openPasswordFileDialog.ShowDialog()

        If File.Exists(openPasswordFileDialog.FileName) Then
            compactor.Path = openPasswordFileDialog.FileName
            passwordListLabel.Text = compactor.compact()
            toolTip.SetToolTip(passwordListLabel, openPasswordFileDialog.FileName)
            passwordListPath = openPasswordFileDialog.FileName
        Else
            storageLabel.Text = "No Password List Selected."
        End If
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        If statusLabel.Text = "Running" Then
            Exit Sub
        End If

        If targetPath = Nothing Then
            MessageBox.Show("No Target Selected.")
            Exit Sub
        End If

        attackManager = New AttackManager(targetPath, storagePath)
        Select Case attackMethod
            Case "bruteforce"
                Dim charset = buildCharset()

                '  Checks information needed to commence a bruteforce attack.
                If charset = "" Then
                    MessageBox.Show("No Charset Was Given.")
                    Exit Sub
                End If
                If minimumTextBox.Text = String.Empty Or Not Integer.TryParse(minimumTextBox.Text, Nothing) Then
                    MessageBox.Show("Invalid Minimum Was Given.")
                    Exit Sub
                End If
                If maximumTextBox.Text = String.Empty Or Not Integer.TryParse(maximumTextBox.Text, Nothing) Then
                    MessageBox.Show("Invalid Maximum Was Given")
                    Exit Sub
                End If
                If minimumTextBox.Text > maximumTextBox.Text Then
                    MessageBox.Show("Minimum Can Not Be Greater Than Maximum.")
                    Exit Sub
                End If

                ' Attacks the given hash file while still giving the user usability of the interface.
                Dim attacker As New BruteForce(charset, minimumTextBox.Text, maximumTextBox.Text)
                attackManager.Attacker = attacker
                totalPossibleLabel.Enabled = True
                totalPossibleLabel.Text = attacker.TotalCombinations.ToString("N0")
            Case "dictionary"
                ' Checks information need to commence a dictinary attack
                If passwordListPath = Nothing Then
                    MessageBox.Show("No Password List Selected.")
                    Exit Sub
                End If

                Dim attacker As New Dictionary(passwordListPath)
                attackManager.Attacker = attacker
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
        elapsedTime = 0
        attemptsPerSecondLabel.Text = 0

        ' Starts the attack manager, statistic manager and timer.
        attackManager.start()
        statThread = New Thread(New ThreadStart(AddressOf updateStats))
        statThread.Start()
        timer.Start()
    End Sub

    ' Updates visuals
    ' Haults the attack manager
    ' Stops the timer.
    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        If statusLabel.Text = "Running" Then
            statusLabel.Text = "Stopped"
            attackManager.hault()
            timer.Enabled = False
        End If
    End Sub

    ' Every tick updates the timer and 
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        elapsedTime += 1
        Dim time = TimeSpan.FromSeconds(elapsedTime)
        elapsedTimeLabel.Text = time.ToString("hh\:mm\:ss")
        attemptsPerSecondLabel.Text = Math.Round(currentAttemptsLabel.Text / elapsedTime, 2).ToString("N2")
    End Sub

    ' Non Handlers
    ' Builds charset that will be used to bruteforce a hash.
    Private Function buildCharset() As String
        Dim builder As New StringBuilder

        If lowerCaseCheckBox.Checked Then
            builder.Append(LOWER_CASES)
        End If

        If upperCaseCheckBox.Checked Then
            builder.Append(UPPER_CASES)
        End If

        If numberCheckBox.Checked Then
            builder.Append(NUMBERS)
        End If

        If symbolsCheckBox.Checked Then
            builder.Append(SYMBOLS)
        End If

        If spacesCheckBox.Checked Then
            builder.Append(SPACES)
        End If

        Return builder.ToString()
    End Function


    ' Flips the attack option between the bruteforce and dictionary attack.
    Private Sub setOptions(ByVal dictionaryOption As Boolean, bruteForceOption As Boolean)
        ' Sets the attak accordingly
        If dictionaryOption Then
            attackMethod = "dictionary"
        Else
            attackMethod = "bruteforce"
        End If

        ' Dictionary options
        passwordListButton.Enabled = dictionaryOption
        passwordListLabel.Enabled = dictionaryOption

        ' Bruteforce options
        lowerCaseCheckBox.Enabled = bruteForceOption
        upperCaseCheckBox.Enabled = bruteForceOption
        numberCheckBox.Enabled = bruteForceOption
        symbolsCheckBox.Enabled = bruteForceOption
        spacesCheckBox.Enabled = bruteForceOption
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
        While attackManager.Running
            updateLabel(attackManager.HashesCracked, hashesBrokeLabel)
            updateLabel(attackManager.Attacker.Attempts.ToString("N0"), currentAttemptsLabel)
        End While
        updateLabel("Stopped", statusLabel)
        timer.Enabled = False
    End Sub
End Class
