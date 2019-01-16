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
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'pwdBox
        '
        Me.pwdBox.Location = New System.Drawing.Point(160, 24)
        Me.pwdBox.Name = "pwdBox"
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
        Me.ProgressBar.Location = New System.Drawing.Point(95, 128)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(359, 23)
        Me.ProgressBar.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 344)
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

End Class
