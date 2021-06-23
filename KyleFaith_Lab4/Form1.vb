Public Class KyleFaithLab04

    Dim Password As String
    Private Sub btnSetPass_Click(sender As Object, e As EventArgs) Handles btnSetPass.Click

        Password = txtSetPass.Text

    End Sub

    Private Sub btnGuessPass_Click(sender As Object, e As EventArgs) Handles btnGuessPass.Click

        Dim guessArray(6) As String
        txtGuessPass.Clear()

        For i As Integer = 0 To 5   'loop 6 times to get every character in the password

            For j As Integer = 1 To 255

                If (Chr(j).Equals(Password.Chars(i))) Then  'if the anscii character is the same as the password character then go into the if statement


                    guessArray(i) = Chr(j)
                    txtGuessPass.Text += guessArray(i)  'prints out guessArray, which is filled with characters from the for loop.

                End If

            Next

        Next

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtGuessPass.Clear()
        txtSetPass.Clear()

    End Sub
End Class
