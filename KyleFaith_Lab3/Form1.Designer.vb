<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PiggyBank
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
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtNickles = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtHalfDollars = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCalculate = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(237, 40)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(100, 20)
        Me.txtPennies.TabIndex = 0
        '
        'txtNickles
        '
        Me.txtNickles.Location = New System.Drawing.Point(237, 79)
        Me.txtNickles.Name = "txtNickles"
        Me.txtNickles.Size = New System.Drawing.Size(100, 20)
        Me.txtNickles.TabIndex = 1
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(237, 122)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(100, 20)
        Me.txtDimes.TabIndex = 2
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(237, 161)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(100, 20)
        Me.txtQuarters.TabIndex = 3
        '
        'txtHalfDollars
        '
        Me.txtHalfDollars.Location = New System.Drawing.Point(237, 198)
        Me.txtHalfDollars.Name = "txtHalfDollars"
        Me.txtHalfDollars.Size = New System.Drawing.Size(100, 20)
        Me.txtHalfDollars.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(85, 255)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCalculate
        '
        Me.txtCalculate.Location = New System.Drawing.Point(191, 257)
        Me.txtCalculate.Name = "txtCalculate"
        Me.txtCalculate.Size = New System.Drawing.Size(146, 20)
        Me.txtCalculate.TabIndex = 6
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(63, 45)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(97, 13)
        Me.lblPennies.TabIndex = 7
        Me.lblPennies.Text = "Number of Pennies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Number of Nickles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Number of Dimes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Number of Quarters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Number of Half Dollars"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 12
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(237, 317)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(110, 317)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'PiggyBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 363)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.txtCalculate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHalfDollars)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtNickles)
        Me.Controls.Add(Me.txtPennies)
        Me.Name = "PiggyBank"
        Me.Text = "PiggyBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPennies As TextBox
    Friend WithEvents txtNickles As TextBox
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents txtHalfDollars As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCalculate As TextBox
    Friend WithEvents lblPennies As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReset As Button
End Class
