Public Class RestaurantBill


    Dim totalCost As Double
    Dim numFries As Integer
    Dim numPizza As Integer
    Dim numDrinks As Integer

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Private Sub btnCost_ClickInput(sender As Object, e As EventArgs) Handles btnCost.Click

        numPizza = CInt(txtPizza.Text)
        numFries = CInt(txtFries.Text)
        numDrinks = CInt(txtDrinks.Text)

        totalCost = calcPrice(numPizza, numFries, numDrinks)


    End Sub

    Private Sub btnCost_ClickOutput(sender As Object, e As EventArgs) Handles btnCost.Click

        Dim fmtString As String = "{0,-10} {1,12} {2,10} "
        Dim fmtPizza As String = "{0,-10} {1,10} {2,10} "
        Dim fmtFries As String = "{0,-10} {1, 12} {2,10}"
        Dim fmtDrinks As String = "{0,-10} {1,11} {2,10} "
        Dim fmtTotal As String = "{0,-10} {1,23}"

        lstBoxMeal.Items.Clear()
        lstBoxMeal.Items.Add(String.Format(fmtString, "Item", "Quantity", "Price"))
        lstBoxMeal.Items.Add(String.Format(fmtString, "", "", ""))
        lstBoxMeal.Items.Add(String.Format(fmtPizza, "pizza slices", numPizza, "$1.25"))
        lstBoxMeal.Items.Add(String.Format(fmtFries, "fries", numFries, "$1.00"))
        lstBoxMeal.Items.Add(String.Format(fmtDrinks, "soft drinks", numDrinks, "$0.75"))
        lstBoxMeal.Items.Add(String.Format(fmtString, "", "", ""))
        lstBoxMeal.Items.Add(String.Format(fmtTotal, "Total", FormatCurrency(totalCost)))

    End Sub

    Private Function calcPrice(ByVal numPizza, ByVal numFries, ByVal numDrinks) As Double


        totalCost = numPizza * 1.25 + numFries * 1.0 + numDrinks * 0.75

        Return totalCost

    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPizza.Clear()
        txtDrinks.Clear()
        txtFries.Clear()
        lstBoxMeal.Items.Clear()
    End Sub
End Class
