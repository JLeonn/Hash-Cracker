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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.defaultsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.visualsGroupBox = New System.Windows.Forms.GroupBox()
        Me.defaultsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'defaultsGroupBox
        '
        Me.defaultsGroupBox.Controls.Add(Me.Label2)
        Me.defaultsGroupBox.Controls.Add(Me.Label1)
        Me.defaultsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaultsGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.defaultsGroupBox.Name = "defaultsGroupBox"
        Me.defaultsGroupBox.Size = New System.Drawing.Size(545, 176)
        Me.defaultsGroupBox.TabIndex = 0
        Me.defaultsGroupBox.TabStop = False
        Me.defaultsGroupBox.Text = "Defaults"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(126, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Storage Location: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(126, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Storage Location: "
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(13, 470)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(110, 23)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(129, 470)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(110, 23)
        Me.resetButton.TabIndex = 2
        Me.resetButton.Text = "Reset All To Default"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'visualsGroupBox
        '
        Me.visualsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visualsGroupBox.Location = New System.Drawing.Point(13, 196)
        Me.visualsGroupBox.Name = "visualsGroupBox"
        Me.visualsGroupBox.Size = New System.Drawing.Size(545, 100)
        Me.visualsGroupBox.TabIndex = 3
        Me.visualsGroupBox.TabStop = False
        Me.visualsGroupBox.Text = "Visuals"
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 517)
        Me.Controls.Add(Me.visualsGroupBox)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.defaultsGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsForm"
        Me.Text = "Options"
        Me.defaultsGroupBox.ResumeLayout(False)
        Me.defaultsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents defaultsGroupBox As GroupBox
    Friend WithEvents saveButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visualsGroupBox As GroupBox
End Class
