Public Class PiggyBank


    'Kyle Faith Lab_02


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Pennies, Nickles, Dimes, Quarters, halfDollars As Integer
        Dim Total As String


        Pennies = CInt(txtPennies.Text)
        Nickles = CInt(txtNickles.Text)
        Dimes = CInt(txtDimes.Text)
        Quarters = CInt(txtQuarters.Text)
        halfDollars = CInt(txtHalfDollars.Text)

        Total = (Pennies * 0.01) + (Nickles * 0.05) + (Dimes * 0.1) + (Quarters * 0.25) + (halfDollars * 0.5)


        FormatCurrency(Total)
        txtCalculate.Text = "$" + Total

        AcceptButton = btnCalculate



    End Sub



    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtPennies.Clear()
        txtNickles.Clear()
        txtDimes.Clear()
        txtQuarters.Clear()
        txtHalfDollars.Clear()
        txtCalculate.Clear()

        Me.Show()
        txtPennies.Focus()

    End Sub
End Class
