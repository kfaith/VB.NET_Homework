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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCardAnswer = New System.Windows.Forms.Label()
        Me.btnThreeOfSpades = New System.Windows.Forms.Button()
        Me.btnRedJoker = New System.Windows.Forms.Button()
        Me.btnJackOfDiamonds = New System.Windows.Forms.Button()
        Me.btnFiveOfClubs = New System.Windows.Forms.Button()
        Me.btnAceOfHearts = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(378, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 47)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCardAnswer
        '
        Me.lblCardAnswer.BackColor = System.Drawing.SystemColors.Control
        Me.lblCardAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCardAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardAnswer.Location = New System.Drawing.Point(26, 339)
        Me.lblCardAnswer.Name = "lblCardAnswer"
        Me.lblCardAnswer.Size = New System.Drawing.Size(814, 35)
        Me.lblCardAnswer.TabIndex = 5
        Me.lblCardAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThreeOfSpades
        '
        Me.btnThreeOfSpades.BackColor = System.Drawing.Color.Transparent
        Me.btnThreeOfSpades.BackgroundImage = Global.PokerCardsReal.My.Resources.Resources._3_Spades
        Me.btnThreeOfSpades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThreeOfSpades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThreeOfSpades.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnThreeOfSpades.Location = New System.Drawing.Point(682, 72)
        Me.btnThreeOfSpades.Name = "btnThreeOfSpades"
        Me.btnThreeOfSpades.Size = New System.Drawing.Size(158, 224)
        Me.btnThreeOfSpades.TabIndex = 10
        Me.btnThreeOfSpades.UseVisualStyleBackColor = False
        '
        'btnRedJoker
        '
        Me.btnRedJoker.BackColor = System.Drawing.Color.Transparent
        Me.btnRedJoker.BackgroundImage = Global.PokerCardsReal.My.Resources.Resources.Joker_Red
        Me.btnRedJoker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRedJoker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRedJoker.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRedJoker.Location = New System.Drawing.Point(518, 72)
        Me.btnRedJoker.Name = "btnRedJoker"
        Me.btnRedJoker.Size = New System.Drawing.Size(158, 224)
        Me.btnRedJoker.TabIndex = 7
        Me.btnRedJoker.UseVisualStyleBackColor = False
        '
        'btnJackOfDiamonds
        '
        Me.btnJackOfDiamonds.BackColor = System.Drawing.Color.Transparent
        Me.btnJackOfDiamonds.BackgroundImage = Global.PokerCardsReal.My.Resources.Resources.Jack_Diamonds
        Me.btnJackOfDiamonds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJackOfDiamonds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJackOfDiamonds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJackOfDiamonds.Location = New System.Drawing.Point(354, 72)
        Me.btnJackOfDiamonds.Name = "btnJackOfDiamonds"
        Me.btnJackOfDiamonds.Size = New System.Drawing.Size(158, 224)
        Me.btnJackOfDiamonds.TabIndex = 6
        Me.btnJackOfDiamonds.UseVisualStyleBackColor = False
        '
        'btnFiveOfClubs
        '
        Me.btnFiveOfClubs.BackColor = System.Drawing.Color.Transparent
        Me.btnFiveOfClubs.BackgroundImage = Global.PokerCardsReal.My.Resources.Resources._5_Clubs
        Me.btnFiveOfClubs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFiveOfClubs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiveOfClubs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFiveOfClubs.Location = New System.Drawing.Point(26, 72)
        Me.btnFiveOfClubs.Name = "btnFiveOfClubs"
        Me.btnFiveOfClubs.Size = New System.Drawing.Size(158, 224)
        Me.btnFiveOfClubs.TabIndex = 8
        Me.btnFiveOfClubs.UseVisualStyleBackColor = False
        '
        'btnAceOfHearts
        '
        Me.btnAceOfHearts.BackColor = System.Drawing.Color.Transparent
        Me.btnAceOfHearts.BackgroundImage = Global.PokerCardsReal.My.Resources.Resources.Ace_Hearts
        Me.btnAceOfHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceOfHearts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceOfHearts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceOfHearts.Location = New System.Drawing.Point(190, 72)
        Me.btnAceOfHearts.Name = "btnAceOfHearts"
        Me.btnAceOfHearts.Size = New System.Drawing.Size(158, 224)
        Me.btnAceOfHearts.TabIndex = 9
        Me.btnAceOfHearts.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(337, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 18)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Click a Card to See Its Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 447)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnThreeOfSpades)
        Me.Controls.Add(Me.btnRedJoker)
        Me.Controls.Add(Me.lblCardAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnJackOfDiamonds)
        Me.Controls.Add(Me.btnFiveOfClubs)
        Me.Controls.Add(Me.btnAceOfHearts)
        Me.Name = "Form1"
        Me.Text = "KyleFaith_Lab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblCardAnswer As Label
    Friend WithEvents btnJackOfDiamonds As Button
    Friend WithEvents btnRedJoker As Button
    Friend WithEvents btnFiveOfClubs As Button
    Friend WithEvents btnAceOfHearts As Button
    Friend WithEvents btnThreeOfSpades As Button
    Friend WithEvents lblTitle As Label
End Class
