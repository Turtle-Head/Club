﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Number1.Click, Number1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, sum As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        sum = num1 + num2
        TextBox3.Text = sum.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, sum As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        sum = num1 - num2
        TextBox3.Text = sum.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, sum As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        sum = num1 * num2
        TextBox3.Text = sum.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, sum As Integer
        num1 = Convert.ToInt32(TextBox1.Text)
        num2 = Convert.ToInt32(TextBox2.Text)
        sum = num1 / num2
        TextBox3.Text = sum.ToString()
    End Sub
End Class
