<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KyleFaithLab04
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
        Me.btnSetPass = New System.Windows.Forms.Button()
        Me.btnGuessPass = New System.Windows.Forms.Button()
        Me.txtSetPass = New System.Windows.Forms.TextBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuessPass = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetPass
        '
        Me.btnSetPass.Location = New System.Drawing.Point(319, 33)
        Me.btnSetPass.Name = "btnSetPass"
        Me.btnSetPass.Size = New System.Drawing.Size(130, 44)
        Me.btnSetPass.TabIndex = 0
        Me.btnSetPass.Text = "Set Password"
        Me.btnSetPass.UseVisualStyleBackColor = True
        '
        'btnGuessPass
        '
        Me.btnGuessPass.Location = New System.Drawing.Point(319, 132)
        Me.btnGuessPass.Name = "btnGuessPass"
        Me.btnGuessPass.Size = New System.Drawing.Size(130, 44)
        Me.btnGuessPass.TabIndex = 1
        Me.btnGuessPass.Text = "Guess Password"
        Me.btnGuessPass.UseVisualStyleBackColor = True
        '
        'txtSetPass
        '
        Me.txtSetPass.Location = New System.Drawing.Point(136, 46)
        Me.txtSetPass.Name = "txtSetPass"
        Me.txtSetPass.Size = New System.Drawing.Size(150, 20)
        Me.txtSetPass.TabIndex = 2
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(41, 49)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(89, 13)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Input Password : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "The password is : "
        '
        'txtGuessPass
        '
        Me.txtGuessPass.Location = New System.Drawing.Point(136, 145)
        Me.txtGuessPass.Name = "txtGuessPass"
        Me.txtGuessPass.Size = New System.Drawing.Size(150, 20)
        Me.txtGuessPass.TabIndex = 5
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(136, 218)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(86, 29)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(247, 218)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 29)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'KyleFaithLab04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 279)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtGuessPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.txtSetPass)
        Me.Controls.Add(Me.btnGuessPass)
        Me.Controls.Add(Me.btnSetPass)
        Me.Name = "KyleFaithLab04"
        Me.Text = "KyleFaith Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetPass As Button
    Friend WithEvents btnGuessPass As Button
    Friend WithEvents txtSetPass As TextBox
    Friend WithEvents lblInput As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGuessPass As TextBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReset As Button
End Class
