Public Class Form1
    Function Myfunc(X As Integer)
        If (X = 0) Then
            Return (X)
        End If
        RTB1.Text += X.ToString() + ","
        Return (Myfunc(X - 1))
    End Function
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(Myfunc(10))
        RTB1.Text += vbCrLf
        MessageBox.Show(Fact6(10))

    End Sub
    Function Fact1(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
        Next
        Return Fact
    End Function

    Function Fact2(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
        Next
        Return Fact * 2
    End Function
    Function Fact3(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
        Next
        Return Fact

    End Function
    Function Fact4(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
        Next
        Return Fact

    End Function
    Function Fact5(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
        Next
        Return Fact

    End Function
    Function Fact6(X As Integer)
        Dim Fact As Double = 1
        For Index = 1 To X
            Fact *= Index
            RTB1.Text += Fact & ","
        Next
        Return Fact
    End Function
    Private Sub FButton_Click(sender As Object, e As EventArgs) Handles FButton.Click
        RTB1.Text += Fact6(10).ToString & vbCrLf
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        If Fx.Text > "" Then
            RTB1.Text += Fact6(Fx.Text).ToString
        Else RTB1.Text += Fact6(15).ToString & vbCrLf
        End If
    End Sub

    Private Sub Clr_Click(sender As Object, e As EventArgs) Handles Clr.Click
        RTB1.Clear()
        Fx.Clear()
    End Sub
End Class
