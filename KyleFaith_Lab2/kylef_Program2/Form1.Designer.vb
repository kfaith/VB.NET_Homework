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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtNickles = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtHalfDollars = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickles = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblHalfDollars = New System.Windows.Forms.Label()
        Me.txtCalculate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(171, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(148, 37)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(244, 353)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(382, 353)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(171, 146)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(100, 20)
        Me.txtQuarters.TabIndex = 6
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(171, 36)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(100, 20)
        Me.txtPennies.TabIndex = 3
        '
        'txtNickles
        '
        Me.txtNickles.Location = New System.Drawing.Point(171, 74)
        Me.txtNickles.Name = "txtNickles"
        Me.txtNickles.Size = New System.Drawing.Size(100, 20)
        Me.txtNickles.TabIndex = 4
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(171, 109)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(100, 20)
        Me.txtDimes.TabIndex = 5
        '
        'txtHalfDollars
        '
        Me.txtHalfDollars.Location = New System.Drawing.Point(171, 181)
        Me.txtHalfDollars.Name = "txtHalfDollars"
        Me.txtHalfDollars.Size = New System.Drawing.Size(100, 20)
        Me.txtHalfDollars.TabIndex = 7
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(39, 39)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(103, 13)
        Me.lblPennies.TabIndex = 8
        Me.lblPennies.Text = "Number of Pennies :"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(39, 112)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(94, 13)
        Me.lblDimes.TabIndex = 9
        Me.lblDimes.Text = "Number of Dimes :"
        '
        'lblNickles
        '
        Me.lblNickles.AutoSize = True
        Me.lblNickles.Location = New System.Drawing.Point(39, 77)
        Me.lblNickles.Name = "lblNickles"
        Me.lblNickles.Size = New System.Drawing.Size(103, 13)
        Me.lblNickles.TabIndex = 10
        Me.lblNickles.Text = "Number of Nickles : "
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(39, 149)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(108, 13)
        Me.lblQuarters.TabIndex = 11
        Me.lblQuarters.Text = "Number of Quarters : "
        '
        'lblHalfDollars
        '
        Me.lblHalfDollars.AutoSize = True
        Me.lblHalfDollars.Location = New System.Drawing.Point(39, 184)
        Me.lblHalfDollars.Name = "lblHalfDollars"
        Me.lblHalfDollars.Size = New System.Drawing.Size(122, 13)
        Me.lblHalfDollars.TabIndex = 12
        Me.lblHalfDollars.Text = "Number of Half Dollars : "
        '
        'txtCalculate
        '
        Me.txtCalculate.Location = New System.Drawing.Point(357, 251)
        Me.txtCalculate.Name = "txtCalculate"
        Me.txtCalculate.Size = New System.Drawing.Size(144, 20)
        Me.txtCalculate.TabIndex = 13
        '
        'PiggyBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 410)
        Me.Controls.Add(Me.txtCalculate)
        Me.Controls.Add(Me.lblHalfDollars)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblNickles)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.txtHalfDollars)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtNickles)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "PiggyBank"
        Me.Text = "Piggy Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents txtNickles As TextBox
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents txtHalfDollars As TextBox
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblNickles As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblHalfDollars As Label
    Friend WithEvents txtCalculate As TextBox
End Class
