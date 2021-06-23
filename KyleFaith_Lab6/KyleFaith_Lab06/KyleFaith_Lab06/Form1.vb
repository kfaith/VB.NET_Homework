Public Class SemesterAverages

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstBoxSocial.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click


        Dim sr As IO.StreamReader = IO.File.OpenText("Data.txt")
        Dim fmtTitle As String = "{0,-10} {1,15}"
        Dim fmtSocial As String = "{0,-10}{1,18}"
        Dim Str_Social(3) As String
        Dim Dbl_Scores(3) As Double

        Dim i As Integer = 0

        lstBoxSocial.Items.Clear()
        lstBoxSocial.Items.Add(String.Format(fmtTitle, "Soc. Sec. No.", "Average"))

        'Loops through the file, putting the Social number into a string array, and the Scores
        'are added and averaged into a double array.
        Do While sr.Peek <> -1
            Str_Social(i) = sr.ReadLine
            Dbl_Scores(i) += CDbl(sr.ReadLine)
            Dbl_Scores(i) += CDbl(sr.ReadLine)
            Dbl_Scores(i) += CDbl(sr.ReadLine)
            Dbl_Scores(i) += CDbl(sr.ReadLine)
            Dbl_Scores(i) = Dbl_Scores(i) / 4

            i += 1
        Loop

        For i = 0 To 2
            lstBoxSocial.Items.Add(String.Format(fmtSocial, Str_Social(i), FormatNumber(Dbl_Scores(i))))
        Next

        sr.Close()

    End Sub
End Class
