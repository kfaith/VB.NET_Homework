' KyleFaith
' Lab 1
' The lab is meant to show 4 different cards, and have the user click any of the 4 cards to reveal what card it is. 
' After clicking the card, the label below should name the card, and then the user can either continue clicking 
' different cards, or exit the program by clicking the exit button below.


Public Class Form1


    Private Sub btnJackOfDiamonds_Click(sender As Object, e As EventArgs) Handles btnJackOfDiamonds.Click
        lblCardAnswer.Text = "Jack of Diamonds"
    End Sub

    Private Sub btnRedJoker_Click(sender As Object, e As EventArgs) Handles btnRedJoker.Click
        lblCardAnswer.Text = "Red Joker"
    End Sub

    Private Sub btnFiveOfClubs_Click(sender As Object, e As EventArgs) Handles btnFiveOfClubs.Click
        lblCardAnswer.Text = "Five of Clubs"
    End Sub

    Private Sub btnAceOfHearts_Click(sender As Object, e As EventArgs) Handles btnAceOfHearts.Click
        lblCardAnswer.Text = "Ace of Hearts"
    End Sub

    Private Sub btnThreeOfSpades_Click(sender As Object, e As EventArgs) Handles btnThreeOfSpades.Click
        lblCardAnswer.Text = "Three of Spades"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub


End Class
