Imports System.DirectoryServices

Public Class Form1
    Private Sub Bfirst_Click(sender As Object, e As EventArgs) Handles Bfirst.Click
        res1.Text = num1.Text + num2.Text
    End Sub

    Private Sub Bsecond_Click(sender As Object, e As EventArgs) Handles Bsecond.Click
        Dim bum3 As Integer = num3.Text
        Dim bum4 As Integer = num4.Text
        res2.Text = bum3 + bum4
    End Sub

    Private Sub spet_Click(sender As Object, e As EventArgs) Handles spet.Click

        otp.Text = res1.Text + res2.Text

    End Sub
End Class
'exercise to evaluate datatypes
'James Fehr February 27, 2023