Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Plus_Click_1(sender As Object, e As EventArgs)
        Dim num1, num2, calc As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        calc = num1 + num2
        TextBox3.Text = calc.ToString()
    End Sub

    Private Sub Minus_Click_1(sender As Object, e As EventArgs)
        Dim num1, num2, calc As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        calc = num1 - num2
        TextBox3.Text = calc.ToString()
    End Sub

    Private Sub Multiply_Click_1(sender As Object, e As EventArgs)
        Dim num1, num2, calc As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        calc = num1 * num2
        TextBox3.Text = calc.ToString()
    End Sub

    Private Sub Divide_Click_1(sender As Object, e As EventArgs)
        Dim num1, num2, calc As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        calc = num1 / num2
        TextBox3.Text = calc.ToString()
    End Sub

    Private Sub ModulusButton_Click_1(sender As Object, e As EventArgs)
        Dim num1, num2, calc As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        calc = num1 Mod num2
        TextBox3.Text = calc.ToString()
    End Sub

End Class
