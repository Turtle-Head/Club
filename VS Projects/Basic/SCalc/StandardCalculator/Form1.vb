Public Class Form1
    Dim calcs As Integer = 0
    Dim operat As String = ""

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "9"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "8"
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "7"
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "6"
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "5"
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "4"
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "3"
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "2"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "1"
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs)
        resultbox.Text += "0"
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        If (resultbox.Text IsNot ".") Then
            resultbox.Text += "."
        End If
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs)
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "+"
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "-"
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "*"
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        calcs = resultbox.Text
        resultbox.Clear()
        operat = "/"
    End Sub

    Private Sub Clr_Click_1(sender As Object, e As EventArgs) Handles Clr.Click
        resultbox.Clear()
    End Sub

    Private Sub bksp_Click_1(sender As Object, e As EventArgs) Handles bksp.Click
        Dim ilenght As Integer = resultbox.TextLength - 1
        Dim result As String = resultbox.Text
        result = result.Substring(0, ilenght)
        resultbox.Text = result
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        If (operat = "+") Then
            resultbox.Text += calcs
        ElseIf (operat = "-") Then
            resultbox.Text -= calcs
        ElseIf (operat = "*") Then
            resultbox.Text *= calcs
        ElseIf (operat = "/") Then
            resultbox.Text /= calcs
        End If
        calcs = 0
        operat = ""
    End Sub

    Private Sub bksp_Click(sender As Object, e As EventArgs) Handles bksp.Click
        Dim ilenght As Integer = resultbox.TextLength - 1
        Dim result As String = resultbox.Text
        result = result.Substring(0, ilenght)
        resultbox.Text = result
    End Sub
End Class
