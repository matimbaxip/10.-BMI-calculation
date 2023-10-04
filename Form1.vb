Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Double
        height = Val(TextBox1.Text)
        weight = Val(TextBox2.Text)
        bmi = weight / (height) ^ 2
        TextBox3.Text = bmi.ToString("F2")

        If bmi < 18 Then

            TextBox4.Text = "You are underweight"

        ElseIf 18 <= bmi And bmi < 26 Then

            TextBox4.Text = "You are normal"

        Else
            TextBox4.Text = "You are overweight"


        End If
    End Sub
End Class
