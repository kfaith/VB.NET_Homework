<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RestaurantBill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPizza = New System.Windows.Forms.Label()
        Me.lblFries = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstBoxMeal = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.lblPizza.Location = New System.Drawing.Point(22, 27)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(157, 17)
        Me.lblPizza.TabIndex = 0
        Me.lblPizza.Text = "How many pizza slices?"
        '
        'lblFries
        '
        Me.lblFries.AutoSize = True
        Me.lblFries.Location = New System.Drawing.Point(67, 72)
        Me.lblFries.Name = "lblFries"
        Me.lblFries.Size = New System.Drawing.Size(112, 17)
        Me.lblFries.TabIndex = 1
        Me.lblFries.Text = "How many fries?"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Location = New System.Drawing.Point(29, 118)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(150, 17)
        Me.lblDrinks.TabIndex = 2
        Me.lblDrinks.Text = "How many soft drinks?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 3
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(185, 115)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(100, 22)
        Me.txtDrinks.TabIndex = 3
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(185, 69)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(100, 22)
        Me.txtFries.TabIndex = 2
        '
        'txtPizza
        '
        Me.txtPizza.Location = New System.Drawing.Point(185, 24)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(100, 22)
        Me.txtPizza.TabIndex = 1
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(291, 113)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(140, 27)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Compute Total Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(113, 340)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 32)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(250, 340)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 32)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstBoxMeal
        '
        Me.lstBoxMeal.ColumnWidth = 3
        Me.lstBoxMeal.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxMeal.FormatString = "C2"
        Me.lstBoxMeal.FormattingEnabled = True
        Me.lstBoxMeal.ItemHeight = 17
        Me.lstBoxMeal.Location = New System.Drawing.Point(52, 168)
        Me.lstBoxMeal.MultiColumn = True
        Me.lstBoxMeal.Name = "lstBoxMeal"
        Me.lstBoxMeal.Size = New System.Drawing.Size(371, 157)
        Me.lstBoxMeal.TabIndex = 10
        '
        'RestaurantBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 402)
        Me.Controls.Add(Me.lstBoxMeal)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblFries)
        Me.Controls.Add(Me.lblPizza)
        Me.Name = "RestaurantBill"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPizza As Label
    Friend WithEvents lblFries As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lstBoxMeal As ListBox
End Class
