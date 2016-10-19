<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.targetButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.passwordListLabel = New System.Windows.Forms.Label()
        Me.passwordListButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.maximumTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.minimumTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.spacesCheckBox = New System.Windows.Forms.CheckBox()
        Me.symbolsCheckBox = New System.Windows.Forms.CheckBox()
        Me.numberCheckBox = New System.Windows.Forms.CheckBox()
        Me.upperCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lowerCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.dictionaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.bruteforceRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.targetLabel = New System.Windows.Forms.Label()
        Me.openTargetFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.totalPossibleLabel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.elapsedTimeLabel = New System.Windows.Forms.Label()
        Me.attemptsPerSecondLabel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.currentAttemptsLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.hashesBrokeLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.storageLabel = New System.Windows.Forms.Label()
        Me.storageButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.stopButton = New System.Windows.Forms.Button()
        Me.openStorageFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.openPasswordFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(130, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Target File: "
        '
        'targetButton
        '
        Me.targetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetButton.Location = New System.Drawing.Point(143, 28)
        Me.targetButton.Name = "targetButton"
        Me.targetButton.Size = New System.Drawing.Size(75, 23)
        Me.targetButton.TabIndex = 2
        Me.targetButton.Text = "Browse"
        Me.targetButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.passwordListLabel)
        Me.GroupBox1.Controls.Add(Me.passwordListButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.maximumTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.minimumTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.spacesCheckBox)
        Me.GroupBox1.Controls.Add(Me.symbolsCheckBox)
        Me.GroupBox1.Controls.Add(Me.numberCheckBox)
        Me.GroupBox1.Controls.Add(Me.upperCaseCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lowerCaseCheckBox)
        Me.GroupBox1.Controls.Add(Me.dictionaryRadioButton)
        Me.GroupBox1.Controls.Add(Me.bruteforceRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0, 15, 17, 15)
        Me.GroupBox1.Size = New System.Drawing.Size(920, 372)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attack Method"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5)
        Me.Label8.Size = New System.Drawing.Size(109, 26)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Password File: "
        '
        'passwordListLabel
        '
        Me.passwordListLabel.AutoSize = True
        Me.passwordListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.passwordListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordListLabel.Location = New System.Drawing.Point(122, 327)
        Me.passwordListLabel.Name = "passwordListLabel"
        Me.passwordListLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.passwordListLabel.Size = New System.Drawing.Size(184, 28)
        Me.passwordListLabel.TabIndex = 20
        Me.passwordListLabel.Text = "No Password List Selected."
        '
        'passwordListButton
        '
        Me.passwordListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordListButton.Location = New System.Drawing.Point(160, 293)
        Me.passwordListButton.Name = "passwordListButton"
        Me.passwordListButton.Size = New System.Drawing.Size(75, 23)
        Me.passwordListButton.TabIndex = 19
        Me.passwordListButton.Text = "Browse"
        Me.passwordListButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(147, 26)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Select Password File:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 15, 15, 15)
        Me.Label9.Size = New System.Drawing.Size(94, 50)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Dictionary"
        '
        'maximumTextBox
        '
        Me.maximumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximumTextBox.Location = New System.Drawing.Point(259, 159)
        Me.maximumTextBox.Name = "maximumTextBox"
        Me.maximumTextBox.Size = New System.Drawing.Size(100, 22)
        Me.maximumTextBox.TabIndex = 15
        Me.maximumTextBox.Text = "8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(176, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(81, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Maximum: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(77, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Minimum: "
        '
        'minimumTextBox
        '
        Me.minimumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimumTextBox.Location = New System.Drawing.Point(259, 117)
        Me.minimumTextBox.Name = "minimumTextBox"
        Me.minimumTextBox.Size = New System.Drawing.Size(100, 22)
        Me.minimumTextBox.TabIndex = 12
        Me.minimumTextBox.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(127, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Password Length: "
        '
        'spacesCheckBox
        '
        Me.spacesCheckBox.AutoSize = True
        Me.spacesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spacesCheckBox.Location = New System.Drawing.Point(16, 217)
        Me.spacesCheckBox.Name = "spacesCheckBox"
        Me.spacesCheckBox.Size = New System.Drawing.Size(74, 20)
        Me.spacesCheckBox.TabIndex = 10
        Me.spacesCheckBox.Text = "Spaces"
        Me.spacesCheckBox.UseVisualStyleBackColor = True
        '
        'symbolsCheckBox
        '
        Me.symbolsCheckBox.AutoSize = True
        Me.symbolsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.symbolsCheckBox.Location = New System.Drawing.Point(16, 191)
        Me.symbolsCheckBox.Name = "symbolsCheckBox"
        Me.symbolsCheckBox.Size = New System.Drawing.Size(80, 20)
        Me.symbolsCheckBox.TabIndex = 9
        Me.symbolsCheckBox.Text = "Symbols"
        Me.symbolsCheckBox.UseVisualStyleBackColor = True
        '
        'numberCheckBox
        '
        Me.numberCheckBox.AutoSize = True
        Me.numberCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberCheckBox.Location = New System.Drawing.Point(16, 165)
        Me.numberCheckBox.Name = "numberCheckBox"
        Me.numberCheckBox.Size = New System.Drawing.Size(82, 20)
        Me.numberCheckBox.TabIndex = 8
        Me.numberCheckBox.Text = "Numbers"
        Me.numberCheckBox.UseVisualStyleBackColor = True
        '
        'upperCaseCheckBox
        '
        Me.upperCaseCheckBox.AutoSize = True
        Me.upperCaseCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upperCaseCheckBox.Location = New System.Drawing.Point(16, 139)
        Me.upperCaseCheckBox.Name = "upperCaseCheckBox"
        Me.upperCaseCheckBox.Size = New System.Drawing.Size(100, 20)
        Me.upperCaseCheckBox.TabIndex = 7
        Me.upperCaseCheckBox.Text = "Upper Case"
        Me.upperCaseCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Charsets: "
        '
        'lowerCaseCheckBox
        '
        Me.lowerCaseCheckBox.AutoSize = True
        Me.lowerCaseCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lowerCaseCheckBox.Location = New System.Drawing.Point(16, 113)
        Me.lowerCaseCheckBox.Name = "lowerCaseCheckBox"
        Me.lowerCaseCheckBox.Size = New System.Drawing.Size(98, 20)
        Me.lowerCaseCheckBox.TabIndex = 5
        Me.lowerCaseCheckBox.Text = "Lower Case"
        Me.lowerCaseCheckBox.UseVisualStyleBackColor = True
        '
        'dictionaryRadioButton
        '
        Me.dictionaryRadioButton.AutoSize = True
        Me.dictionaryRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dictionaryRadioButton.Location = New System.Drawing.Point(97, 260)
        Me.dictionaryRadioButton.Name = "dictionaryRadioButton"
        Me.dictionaryRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.dictionaryRadioButton.TabIndex = 4
        Me.dictionaryRadioButton.TabStop = True
        Me.dictionaryRadioButton.UseVisualStyleBackColor = True
        '
        'bruteforceRadioButton
        '
        Me.bruteforceRadioButton.AutoSize = True
        Me.bruteforceRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bruteforceRadioButton.Location = New System.Drawing.Point(101, 52)
        Me.bruteforceRadioButton.Name = "bruteforceRadioButton"
        Me.bruteforceRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.bruteforceRadioButton.TabIndex = 3
        Me.bruteforceRadioButton.TabStop = True
        Me.bruteforceRadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 15, 15, 15)
        Me.Label3.Size = New System.Drawing.Size(108, 50)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Brute Force"
        '
        'targetLabel
        '
        Me.targetLabel.AutoSize = True
        Me.targetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.targetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetLabel.Location = New System.Drawing.Point(102, 61)
        Me.targetLabel.Name = "targetLabel"
        Me.targetLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.targetLabel.Size = New System.Drawing.Size(171, 28)
        Me.targetLabel.TabIndex = 5
        Me.targetLabel.Text = "No Target Path Selected."
        '
        'openTargetFileDialog
        '
        Me.openTargetFileDialog.Title = "Target Selection."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5)
        Me.Label10.Size = New System.Drawing.Size(89, 26)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Target File: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.totalPossibleLabel)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.elapsedTimeLabel)
        Me.GroupBox2.Controls.Add(Me.attemptsPerSecondLabel)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.currentAttemptsLabel)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.hashesBrokeLabel)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.statusLabel)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 506)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 197)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistics"
        '
        'totalPossibleLabel
        '
        Me.totalPossibleLabel.AutoSize = True
        Me.totalPossibleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPossibleLabel.Location = New System.Drawing.Point(185, 131)
        Me.totalPossibleLabel.Name = "totalPossibleLabel"
        Me.totalPossibleLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.totalPossibleLabel.Size = New System.Drawing.Size(23, 23)
        Me.totalPossibleLabel.TabIndex = 11
        Me.totalPossibleLabel.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(5)
        Me.Label18.Size = New System.Drawing.Size(166, 26)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Total Possible Attempts: "
        '
        'elapsedTimeLabel
        '
        Me.elapsedTimeLabel.AutoSize = True
        Me.elapsedTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elapsedTimeLabel.Location = New System.Drawing.Point(128, 158)
        Me.elapsedTimeLabel.Name = "elapsedTimeLabel"
        Me.elapsedTimeLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.elapsedTimeLabel.Size = New System.Drawing.Size(59, 23)
        Me.elapsedTimeLabel.TabIndex = 9
        Me.elapsedTimeLabel.Text = "00:00:00"
        '
        'attemptsPerSecondLabel
        '
        Me.attemptsPerSecondLabel.AutoSize = True
        Me.attemptsPerSecondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attemptsPerSecondLabel.Location = New System.Drawing.Point(152, 106)
        Me.attemptsPerSecondLabel.Name = "attemptsPerSecondLabel"
        Me.attemptsPerSecondLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.attemptsPerSecondLabel.Size = New System.Drawing.Size(23, 23)
        Me.attemptsPerSecondLabel.TabIndex = 8
        Me.attemptsPerSecondLabel.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(5)
        Me.Label17.Size = New System.Drawing.Size(133, 26)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Attempts / Second: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(5)
        Me.Label16.Size = New System.Drawing.Size(109, 26)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Elapsed Time: "
        '
        'currentAttemptsLabel
        '
        Me.currentAttemptsLabel.AutoSize = True
        Me.currentAttemptsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentAttemptsLabel.Location = New System.Drawing.Point(95, 80)
        Me.currentAttemptsLabel.Name = "currentAttemptsLabel"
        Me.currentAttemptsLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.currentAttemptsLabel.Size = New System.Drawing.Size(23, 23)
        Me.currentAttemptsLabel.TabIndex = 5
        Me.currentAttemptsLabel.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(5)
        Me.Label14.Size = New System.Drawing.Size(76, 26)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Attempts: "
        '
        'hashesBrokeLabel
        '
        Me.hashesBrokeLabel.AutoSize = True
        Me.hashesBrokeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hashesBrokeLabel.Location = New System.Drawing.Point(129, 54)
        Me.hashesBrokeLabel.Name = "hashesBrokeLabel"
        Me.hashesBrokeLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.hashesBrokeLabel.Size = New System.Drawing.Size(23, 23)
        Me.hashesBrokeLabel.TabIndex = 3
        Me.hashesBrokeLabel.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(5)
        Me.Label15.Size = New System.Drawing.Size(110, 26)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Hashes Broke: "
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(80, 25)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.statusLabel.Size = New System.Drawing.Size(70, 26)
        Me.statusLabel.TabIndex = 1
        Me.statusLabel.Text = "Stopped"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(5)
        Me.Label12.Size = New System.Drawing.Size(61, 26)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Status: "
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(12, 709)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 24
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(467, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(97, 26)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Storage File: "
        '
        'storageLabel
        '
        Me.storageLabel.AutoSize = True
        Me.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.storageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageLabel.Location = New System.Drawing.Point(570, 61)
        Me.storageLabel.Name = "storageLabel"
        Me.storageLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.storageLabel.Size = New System.Drawing.Size(179, 28)
        Me.storageLabel.TabIndex = 28
        Me.storageLabel.Text = "No Storage Path Selected."
        '
        'storageButton
        '
        Me.storageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageButton.Location = New System.Drawing.Point(611, 31)
        Me.storageButton.Name = "storageButton"
        Me.storageButton.Size = New System.Drawing.Size(75, 23)
        Me.storageButton.TabIndex = 27
        Me.storageButton.Text = "Browse"
        Me.storageButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(467, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(138, 26)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Select Storage File: "
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'stopButton
        '
        Me.stopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopButton.Location = New System.Drawing.Point(96, 709)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 30
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'openStorageFileDialog
        '
        Me.openStorageFileDialog.Title = "Storage Selection."
        '
        'openPasswordFileDialog
        '
        Me.openPasswordFileDialog.Title = "Password List Selection"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.targetButton)
        Me.GroupBox3.Controls.Add(Me.storageLabel)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.targetLabel)
        Me.GroupBox3.Controls.Add(Me.storageButton)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(920, 110)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File Selection"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(959, 743)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Hash Cracker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents targetButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dictionaryRadioButton As RadioButton
    Friend WithEvents bruteforceRadioButton As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents maximumTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents minimumTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents spacesCheckBox As CheckBox
    Friend WithEvents symbolsCheckBox As CheckBox
    Friend WithEvents numberCheckBox As CheckBox
    Friend WithEvents upperCaseCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lowerCaseCheckBox As CheckBox
    Friend WithEvents passwordListButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents targetLabel As Label
    Friend WithEvents openTargetFileDialog As OpenFileDialog
    Friend WithEvents passwordListLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents startButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents storageLabel As Label
    Friend WithEvents storageButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents hashesBrokeLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents currentAttemptsLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents timer As Timer
    Friend WithEvents elapsedTimeLabel As Label
    Friend WithEvents attemptsPerSecondLabel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents stopButton As Button
    Friend WithEvents totalPossibleLabel As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents openStorageFileDialog As OpenFileDialog
    Friend WithEvents openPasswordFileDialog As OpenFileDialog
    Friend WithEvents GroupBox3 As GroupBox
End Class
