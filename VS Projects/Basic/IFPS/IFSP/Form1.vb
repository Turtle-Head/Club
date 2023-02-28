Public Class Form1
    'Exercise IF statement 
    'James Fehr 2023-02-28


    Private Sub eotest_Click(sender As Object, e As EventArgs)
        Dim x As Integer = num1.Text
        Dim y As Integer = num2.Text
        If (x Mod 2 = 0) Then
            resbox.Text = "Even"
        Else
            resbox.Text = "Odd"
        End If
        If (y Mod 2 = 0) Then
            resbox2.Text = "Even"
        Else
            resbox2.Text = "Odd"
        End If
    End Sub

    Private Sub FBcheck_Click_1(sender As Object, e As EventArgs)
        Dim z As Integer = fbval.Text
        If (z Mod 3 = 0) And (z Mod 5 = 0) Then
            fbres.Text = "FizzBuzz"
        ElseIf (z Mod 3 = 0) Then
            fbres.Text = "Fizz"
        ElseIf (z Mod 5 = 0) Then
            fbres.Text = "Buzz"
        Else
            fbres.Text = "No Fizz No Buzz"
        End If
    End Sub
End Class
