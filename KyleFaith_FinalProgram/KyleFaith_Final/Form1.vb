Public Class Form1

    Dim randomNum As New Random()
    Dim x, y, xPos, yPos As Integer
    Dim gr As Graphics
    Dim randColor As Color
    Dim myRectangle As Rectangle

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Chooses a random color and opacity
        Dim randBrush As New SolidBrush(Color.FromArgb(randomNum.Next(1, 255), randomNum.Next(1, 255), randomNum.Next(1, 255), randomNum.Next(1, 255)))

        'Chooses a random size between 30 and 80.
        x = randomNum.Next(30, 80)
        y = randomNum.Next(30, 80)
        'Chooses a random position(the top left corner) for the rectangle.
        xPos = randomNum.Next(1, Screen.PrimaryScreen.Bounds.Width - x)
        yPos = randomNum.Next(1, Screen.PrimaryScreen.Bounds.Height - y)

        gr = pictBox.CreateGraphics
        'Makes a rectangle with the random color, position, and size.
        gr.FillRectangle(randBrush, xPos, yPos, x, y)

    End Sub




    Private Sub pictBox_Click(sender As Object, e As EventArgs) Handles pictBox.Click

        'If the timer isnt running when left clicked, start timer. If timer is running when left clicked, stop timer.
        If Timer1.Enabled = False Then

            Timer1.Enabled = True

        ElseIf (Timer1.Enabled = True) Then

            Timer1.Enabled = False

        End If

    End Sub


End Class
