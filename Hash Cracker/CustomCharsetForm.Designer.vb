<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomCharsetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomCharsetForm))
        Me.setCharsetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.spacesCheckBox = New System.Windows.Forms.CheckBox()
        Me.symbolsCheckBox = New System.Windows.Forms.CheckBox()
        Me.numberCheckBox = New System.Windows.Forms.CheckBox()
        Me.upperCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lowerCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'setCharsetButton
        '
        resources.ApplyResources(Me.setCharsetButton, "setCharsetButton")
        Me.setCharsetButton.Name = "setCharsetButton"
        Me.setCharsetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'textBox
        '
        resources.ApplyResources(Me.textBox, "textBox")
        Me.textBox.Name = "textBox"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'spacesCheckBox
        '
        resources.ApplyResources(Me.spacesCheckBox, "spacesCheckBox")
        Me.spacesCheckBox.Name = "spacesCheckBox"
        Me.spacesCheckBox.UseVisualStyleBackColor = True
        '
        'symbolsCheckBox
        '
        resources.ApplyResources(Me.symbolsCheckBox, "symbolsCheckBox")
        Me.symbolsCheckBox.Name = "symbolsCheckBox"
        Me.symbolsCheckBox.UseVisualStyleBackColor = True
        '
        'numberCheckBox
        '
        resources.ApplyResources(Me.numberCheckBox, "numberCheckBox")
        Me.numberCheckBox.Name = "numberCheckBox"
        Me.numberCheckBox.UseVisualStyleBackColor = True
        '
        'upperCaseCheckBox
        '
        resources.ApplyResources(Me.upperCaseCheckBox, "upperCaseCheckBox")
        Me.upperCaseCheckBox.Name = "upperCaseCheckBox"
        Me.upperCaseCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lowerCaseCheckBox
        '
        resources.ApplyResources(Me.lowerCaseCheckBox, "lowerCaseCheckBox")
        Me.lowerCaseCheckBox.Name = "lowerCaseCheckBox"
        Me.lowerCaseCheckBox.UseVisualStyleBackColor = True
        '
        'CustomCharsetForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.spacesCheckBox)
        Me.Controls.Add(Me.symbolsCheckBox)
        Me.Controls.Add(Me.numberCheckBox)
        Me.Controls.Add(Me.upperCaseCheckBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lowerCaseCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.setCharsetButton)
        Me.Name = "CustomCharsetForm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents setCharsetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents spacesCheckBox As CheckBox
    Friend WithEvents symbolsCheckBox As CheckBox
    Friend WithEvents numberCheckBox As CheckBox
    Friend WithEvents upperCaseCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lowerCaseCheckBox As CheckBox
End Class
