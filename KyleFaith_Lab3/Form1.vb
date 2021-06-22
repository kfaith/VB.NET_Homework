Public Class PiggyBank

    'Kyle Faith Lab_02

    'NEW FUNCTIONS TO ADD COINS
    Function numPennies(ByVal Pennies As Integer)

        Dim sumPennies As Double
        sumPennies = (Pennies * 0.01)
        Return sumPennies

    End Function

    Function numNickles(ByVal Nickles As Integer)

        Dim sumNickles As Double
        sumNickles = (Nickles * 0.05)
        Return sumNickles

    End Function

    Function numDimes(ByVal Dimes As Integer)

        Dim sumDimes As Double
        sumDimes = (Dimes * 0.1)
        Return sumDimes

    End Function

    Function numQuarters(ByVal Quarters As Integer)

        Dim sumQuarters As Double
        sumQuarters = (Quarters * 0.25)
        Return sumQuarters

    End Function

    Function numHalfDollars(ByVal HalfDollars As Integer)

        Dim sumHalfDollars As Double
        sumHalfDollars = (HalfDollars * 0.5)
        Return sumHalfDollars

    End Function



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        CalculateMoney()

    End Sub

    'NEW SUBROUTINE TO CALCULATE THE MONEY USING THE FUNCTIONS
    Private Sub CalculateMoney()

        Dim Total As String

        Total = numPennies(txtPennies.Text) + numNickles(txtNickles.Text) + numDimes(txtDimes.Text) + numQuarters(txtQuarters.Text) + numHalfDollars(txtHalfDollars.Text)

        FormatCurrency(Total)
        txtCalculate.Text = "$" + Total

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

