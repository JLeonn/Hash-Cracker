<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.defaultPathGroupBox = New System.Windows.Forms.GroupBox()
        Me.passwordListLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.passwordListButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.targetButton = New System.Windows.Forms.Button()
        Me.storageLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.targetLabel = New System.Windows.Forms.Label()
        Me.storageButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.charsetLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buildCharsetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.visualsGroupBox = New System.Windows.Forms.GroupBox()
        Me.openTargetFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.openStorageFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.openPasswordFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.optionDefaultTextBox = New System.Windows.Forms.GroupBox()
        Me.maximumTextBox = New System.Windows.Forms.TextBox()
        Me.minimumTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.defaultPathGroupBox.SuspendLayout()
        Me.optionDefaultTextBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'defaultPathGroupBox
        '
        Me.defaultPathGroupBox.Controls.Add(Me.passwordListLabel)
        Me.defaultPathGroupBox.Controls.Add(Me.Label5)
        Me.defaultPathGroupBox.Controls.Add(Me.passwordListButton)
        Me.defaultPathGroupBox.Controls.Add(Me.Label6)
        Me.defaultPathGroupBox.Controls.Add(Me.Label4)
        Me.defaultPathGroupBox.Controls.Add(Me.targetButton)
        Me.defaultPathGroupBox.Controls.Add(Me.storageLabel)
        Me.defaultPathGroupBox.Controls.Add(Me.Label11)
        Me.defaultPathGroupBox.Controls.Add(Me.Label10)
        Me.defaultPathGroupBox.Controls.Add(Me.targetLabel)
        Me.defaultPathGroupBox.Controls.Add(Me.storageButton)
        Me.defaultPathGroupBox.Controls.Add(Me.Label13)
        Me.defaultPathGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaultPathGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.defaultPathGroupBox.Name = "defaultPathGroupBox"
        Me.defaultPathGroupBox.Size = New System.Drawing.Size(494, 265)
        Me.defaultPathGroupBox.TabIndex = 0
        Me.defaultPathGroupBox.TabStop = False
        Me.defaultPathGroupBox.Text = "Path Defaults"
        '
        'passwordListLabel
        '
        Me.passwordListLabel.AutoSize = True
        Me.passwordListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.passwordListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordListLabel.Location = New System.Drawing.Point(136, 209)
        Me.passwordListLabel.Name = "passwordListLabel"
        Me.passwordListLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.passwordListLabel.Size = New System.Drawing.Size(199, 28)
        Me.passwordListLabel.TabIndex = 44
        Me.passwordListLabel.Text = "No Default Password List Path"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(124, 26)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Password File: "
        '
        'passwordListButton
        '
        Me.passwordListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordListButton.Location = New System.Drawing.Point(205, 174)
        Me.passwordListButton.Name = "passwordListButton"
        Me.passwordListButton.Size = New System.Drawing.Size(75, 23)
        Me.passwordListButton.TabIndex = 43
        Me.passwordListButton.Text = "Browse"
        Me.passwordListButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(193, 26)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Select Default Password List: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(175, 26)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Select Default Target File: "
        '
        'targetButton
        '
        Me.targetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetButton.Location = New System.Drawing.Point(187, 34)
        Me.targetButton.Name = "targetButton"
        Me.targetButton.Size = New System.Drawing.Size(75, 23)
        Me.targetButton.TabIndex = 31
        Me.targetButton.Text = "Browse"
        Me.targetButton.UseVisualStyleBackColor = True
        '
        'storageLabel
        '
        Me.storageLabel.AutoSize = True
        Me.storageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.storageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageLabel.Location = New System.Drawing.Point(123, 136)
        Me.storageLabel.Name = "storageLabel"
        Me.storageLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.storageLabel.Size = New System.Drawing.Size(224, 28)
        Me.storageLabel.TabIndex = 36
        Me.storageLabel.Text = "No Default Storage Path Selected."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(111, 26)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Storage File: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5)
        Me.Label10.Size = New System.Drawing.Size(102, 26)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Target File: "
        '
        'targetLabel
        '
        Me.targetLabel.AutoSize = True
        Me.targetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.targetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetLabel.Location = New System.Drawing.Point(114, 64)
        Me.targetLabel.Name = "targetLabel"
        Me.targetLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.targetLabel.Size = New System.Drawing.Size(216, 28)
        Me.targetLabel.TabIndex = 32
        Me.targetLabel.Text = "No Default Target Path Selected."
        '
        'storageButton
        '
        Me.storageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storageButton.Location = New System.Drawing.Point(195, 106)
        Me.storageButton.Name = "storageButton"
        Me.storageButton.Size = New System.Drawing.Size(75, 23)
        Me.storageButton.TabIndex = 35
        Me.storageButton.Text = "Browse"
        Me.storageButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(183, 26)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Select Default Storage File: "
        '
        'charsetLabel
        '
        Me.charsetLabel.AutoSize = True
        Me.charsetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.charsetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charsetLabel.Location = New System.Drawing.Point(91, 69)
        Me.charsetLabel.Name = "charsetLabel"
        Me.charsetLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.charsetLabel.Size = New System.Drawing.Size(163, 28)
        Me.charsetLabel.TabIndex = 40
        Me.charsetLabel.Text = "No Default Charset Built."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Charset: "
        '
        'buildCharsetButton
        '
        Me.buildCharsetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buildCharsetButton.Location = New System.Drawing.Point(160, 34)
        Me.buildCharsetButton.Name = "buildCharsetButton"
        Me.buildCharsetButton.Size = New System.Drawing.Size(75, 23)
        Me.buildCharsetButton.TabIndex = 39
        Me.buildCharsetButton.Text = "Build"
        Me.buildCharsetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(148, 26)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Build Default Charset: "
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(12, 389)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(110, 23)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(128, 389)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(110, 23)
        Me.clearButton.TabIndex = 2
        Me.clearButton.Text = "Clear All Settings"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'visualsGroupBox
        '
        Me.visualsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visualsGroupBox.Location = New System.Drawing.Point(12, 283)
        Me.visualsGroupBox.Name = "visualsGroupBox"
        Me.visualsGroupBox.Size = New System.Drawing.Size(884, 100)
        Me.visualsGroupBox.TabIndex = 3
        Me.visualsGroupBox.TabStop = False
        Me.visualsGroupBox.Text = "Visuals"
        '
        'optionDefaultTextBox
        '
        Me.optionDefaultTextBox.Controls.Add(Me.maximumTextBox)
        Me.optionDefaultTextBox.Controls.Add(Me.minimumTextBox)
        Me.optionDefaultTextBox.Controls.Add(Me.Label7)
        Me.optionDefaultTextBox.Controls.Add(Me.Label2)
        Me.optionDefaultTextBox.Controls.Add(Me.Label1)
        Me.optionDefaultTextBox.Controls.Add(Me.charsetLabel)
        Me.optionDefaultTextBox.Controls.Add(Me.buildCharsetButton)
        Me.optionDefaultTextBox.Controls.Add(Me.Label3)
        Me.optionDefaultTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionDefaultTextBox.Location = New System.Drawing.Point(512, 12)
        Me.optionDefaultTextBox.Name = "optionDefaultTextBox"
        Me.optionDefaultTextBox.Size = New System.Drawing.Size(384, 265)
        Me.optionDefaultTextBox.TabIndex = 4
        Me.optionDefaultTextBox.TabStop = False
        Me.optionDefaultTextBox.Text = "Option Defaults"
        '
        'maximumTextBox
        '
        Me.maximumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximumTextBox.Location = New System.Drawing.Point(150, 142)
        Me.maximumTextBox.Name = "maximumTextBox"
        Me.maximumTextBox.Size = New System.Drawing.Size(28, 22)
        Me.maximumTextBox.TabIndex = 45
        Me.maximumTextBox.Text = "8"
        Me.maximumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'minimumTextBox
        '
        Me.minimumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimumTextBox.Location = New System.Drawing.Point(150, 107)
        Me.minimumTextBox.Name = "minimumTextBox"
        Me.minimumTextBox.Size = New System.Drawing.Size(28, 22)
        Me.minimumTextBox.TabIndex = 44
        Me.minimumTextBox.Text = "1"
        Me.minimumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(138, 26)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Brute Force Max: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(134, 26)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Brute Force Min: "
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 669)
        Me.Controls.Add(Me.optionDefaultTextBox)
        Me.Controls.Add(Me.visualsGroupBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.defaultPathGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsForm"
        Me.Text = "Options"
        Me.defaultPathGroupBox.ResumeLayout(False)
        Me.defaultPathGroupBox.PerformLayout()
        Me.optionDefaultTextBox.ResumeLayout(False)
        Me.optionDefaultTextBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents defaultPathGroupBox As GroupBox
    Friend WithEvents saveButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents visualsGroupBox As GroupBox
    Friend WithEvents charsetLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents buildCharsetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents targetButton As Button
    Friend WithEvents storageLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents targetLabel As Label
    Friend WithEvents storageButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents openTargetFileDialog As OpenFileDialog
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents openStorageFileDialog As OpenFileDialog
    Friend WithEvents passwordListLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents passwordListButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents openPasswordFileDialog As OpenFileDialog
    Friend WithEvents optionDefaultTextBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents maximumTextBox As TextBox
    Friend WithEvents minimumTextBox As TextBox
End Class
