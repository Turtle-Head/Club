Public Class Form1
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Out.Text = "Good Morning Dave..."
    End Sub

    Private Sub CM_Click(sender As Object, e As EventArgs) Handles CM.Click
        Out.Text += vbCrLf & "Prepare the Rockets!!"
    End Sub

End Class
