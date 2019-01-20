<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.password = New System.Windows.Forms.Label()
        Me.strgLabel = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.pwdBox = New System.Windows.Forms.TextBox()
        Me.strString = New System.Windows.Forms.Label()
        Me.hideChkBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.suglbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(25, 29)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(107, 17)
        Me.password.TabIndex = 0
        Me.password.Text = "Enter Password"
        '
        'strgLabel
        '
        Me.strgLabel.AutoSize = True
        Me.strgLabel.Location = New System.Drawing.Point(241, 203)
        Me.strgLabel.Name = "strgLabel"
        Me.strgLabel.Size = New System.Drawing.Size(28, 17)
        Me.strgLabel.TabIndex = 4
        Me.strgLabel.Text = "0%"
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProgressBar.Location = New System.Drawing.Point(85, 144)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(359, 23)
        Me.ProgressBar.TabIndex = 5
        '
        'pwdBox
        '
        Me.pwdBox.Location = New System.Drawing.Point(160, 29)
        Me.pwdBox.Name = "pwdBox"
        Me.pwdBox.Size = New System.Drawing.Size(338, 22)
        Me.pwdBox.TabIndex = 8
        '
        'strString
        '
        Me.strString.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strString.Location = New System.Drawing.Point(168, 237)
        Me.strString.Name = "strString"
        Me.strString.Size = New System.Drawing.Size(174, 25)
        Me.strString.TabIndex = 9
        Me.strString.Text = "Too Short"
        Me.strString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hideChkBox
        '
        Me.hideChkBox.AutoSize = True
        Me.hideChkBox.Location = New System.Drawing.Point(160, 85)
        Me.hideChkBox.Name = "hideChkBox"
        Me.hideChkBox.Size = New System.Drawing.Size(59, 21)
        Me.hideChkBox.TabIndex = 10
        Me.hideChkBox.Text = "Hide"
        Me.hideChkBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Suggestions"
        '
        'suglbl
        '
        Me.suglbl.AutoSize = True
        Me.suglbl.Location = New System.Drawing.Point(25, 317)
        Me.suglbl.Name = "suglbl"
        Me.suglbl.Size = New System.Drawing.Size(0, 17)
        Me.suglbl.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 590)
        Me.Controls.Add(Me.suglbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hideChkBox)
        Me.Controls.Add(Me.strString)
        Me.Controls.Add(Me.pwdBox)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.strgLabel)
        Me.Controls.Add(Me.password)
        Me.Name = "Form1"
        Me.Text = "Password Strength Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents strgLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents pwdBox As TextBox
    Friend WithEvents strString As System.Windows.Forms.Label
    Friend WithEvents hideChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents suglbl As System.Windows.Forms.Label
End Class
