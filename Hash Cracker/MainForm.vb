Imports System.IO
Imports System.Text
Imports System.Threading

' Contains all the handlers for the main form.
Public Class MainForm
    Private parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
    Private defaultStoragePath = parentDirectory & "\Crack Session.txt"

    Private attackMethod As String
    Private targetPath As String
    Private storagePath As String
    Private attackManager As AttackManager
    Private statThread As Thread

    Private Delegate Sub SetTextCallBack([text] As String, label As Label)

    Private elapsedTime As Integer

    ' On load
    Private Sub HashCracker_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Pass
    End Sub

    Private Sub targetButton_Click(sender As Object, e As EventArgs) Handles targetButton.Click
        OpenFileDialog.Title = "Target Selection"
        OpenFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
        OpenFileDialog.ShowDialog()

        targetLabel.Text = OpenFileDialog.FileName
        targetPath = OpenFileDialog.FileName
    End Sub

    Private Sub storageButton_Click(sender As Object, e As EventArgs) Handles storageButton.Click
        OpenFileDialog.Title = "Storage Selection"
        OpenFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
        OpenFileDialog.ShowDialog()

        storageLabel.Text = OpenFileDialog.FileName
        storagePath = OpenFileDialog.FileName
    End Sub

    Private Sub bruteforceRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles bruteforceRadioButton.CheckedChanged
        setOptions(False, True)
    End Sub

    Private Sub dictionaryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles dictionaryRadioButton.CheckedChanged
        setOptions(True, False)
    End Sub

    Private Sub passwordListButton_Click(sender As Object, e As EventArgs) Handles passwordListButton.Click
        OpenFileDialog.Title = "Password List Selection"
        OpenFileDialog.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString()
        OpenFileDialog.ShowDialog()

        passwordListLabel.Text = OpenFileDialog.FileName
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click

        ' Checks given path information.
        If Not File.Exists(targetPath) Then
            MessageBox.Show("Invalid Target Path.")
            Exit Sub
        End If
        If Not File.Exists(storagePath) Then
            storagePath = defaultStoragePath
        Else
            storagePath = storageLabel.Text
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
                If minimumTextBox.Text = String.Empty Then
                    MessageBox.Show("No Minimum Was Given.")
                    Exit Sub
                End If
                If maximumTextBox.Text = String.Empty Then
                    MessageBox.Show("No Maximum Was Given")
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
                totalPossibleLabel.Text = attacker.TotalCombinations
            Case "dictionary"
                ' Checks information need to commence a dictinary attack
                If Not File.Exists(passwordListLabel.Text) Then
                    MessageBox.Show("Invalid Password List Path.")
                    Exit Sub
                End If

                Dim attacker As New Dictionary(passwordListLabel.Text)
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
        If IsNothing(attackManager) Then
            Exit Sub
        End If

        If attackManager.Running Then
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
        attemptsPerSecondLabel.Text = Math.Round(currentAttemptsLabel.Text / elapsedTime, 2)
    End Sub

    ' Non Handlers
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

        ' Bruteforce options
        lowerCaseCheckBox.Enabled = bruteForceOption
        upperCaseCheckBox.Enabled = bruteForceOption
        numberCheckBox.Enabled = bruteForceOption
        symbolsCheckBox.Enabled = bruteForceOption
        spacesCheckBox.Enabled = bruteForceOption
        minimumTextBox.Enabled = bruteForceOption
        maximumTextBox.Enabled = bruteForceOption
    End Sub

    ' Builds the wanted character set via check boxes.
    Private Function buildCharset() As String
        Dim charset As New StringBuilder

        ' Checks each textbox and builds a string whether the box is checked or not.
        If lowerCaseCheckBox.Checked Then
            charset.Append(LOWER_CASES)
        End If

        If upperCaseCheckBox.Checked Then
            charset.Append(UPPER_CASES)
        End If

        If numberCheckBox.Checked Then
            charset.Append(NUMBERS)
        End If

        If symbolsCheckBox.Checked Then
            charset.Append(SYMBOLS)
        End If

        If spacesCheckBox.Checked Then
            charset.Append(SPACES)
        End If

        Return charset.ToString()
    End Function

    ' The threaded action that maintains the statistal tab.
    Public Sub updateStats()
        While attackManager.Running
            updateLabel(attackManager.HashesCracked, hashesBrokeLabel)
            updateLabel(attackManager.Attacker.Attempts, currentAttemptsLabel)
        End While
        updateLabel("Stopped", statusLabel)
        timer.Enabled = False
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
End Class
