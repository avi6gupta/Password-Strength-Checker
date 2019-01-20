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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.pwdBox = New System.Windows.Forms.TextBox()
        Me.strgLabel = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.seqlbl = New System.Windows.Forms.Label()
        Me.pwdBoxEnter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(423, 289)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'pwdBox
        '
        Me.pwdBox.Location = New System.Drawing.Point(160, 65)
        Me.pwdBox.Name = "pwdBox"
        Me.pwdBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.pwdBox.Size = New System.Drawing.Size(338, 22)
        Me.pwdBox.TabIndex = 3
        '
        'strgLabel
        '
        Me.strgLabel.AutoSize = True
        Me.strgLabel.Location = New System.Drawing.Point(241, 185)
        Me.strgLabel.Name = "strgLabel"
        Me.strgLabel.Size = New System.Drawing.Size(71, 17)
        Me.strgLabel.TabIndex = 4
        Me.strgLabel.Text = "Too Short"
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProgressBar.Location = New System.Drawing.Point(95, 128)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(359, 23)
        Me.ProgressBar.TabIndex = 5
        '
        'seqlbl
        '
        Me.seqlbl.AutoSize = True
        Me.seqlbl.Location = New System.Drawing.Point(241, 258)
        Me.seqlbl.Name = "seqlbl"
        Me.seqlbl.Size = New System.Drawing.Size(51, 17)
        Me.seqlbl.TabIndex = 6
        Me.seqlbl.Text = "Label1"
        '
        'pwdBoxEnter
        '
        Me.pwdBoxEnter.Location = New System.Drawing.Point(160, 29)
        Me.pwdBoxEnter.Name = "pwdBoxEnter"
        Me.pwdBoxEnter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.pwdBoxEnter.Size = New System.Drawing.Size(338, 22)
        Me.pwdBoxEnter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Confirm Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 344)
        Me.Controls.Add(Me.pwdBoxEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seqlbl)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.strgLabel)
        Me.Controls.Add(Me.pwdBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.password)
        Me.Name = "Form1"
        Me.Text = "Password Strength Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents pwdBox As System.Windows.Forms.TextBox
    Friend WithEvents strgLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents seqlbl As System.Windows.Forms.Label
    Friend WithEvents pwdBoxEnter As TextBox
    Friend WithEvents Label1 As Label
End Class
