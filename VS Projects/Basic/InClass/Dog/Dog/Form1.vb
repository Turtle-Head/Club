Imports Dog
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Plato As New Dog("Gary", 2, "wolf", "grey")
        TB.Text = Plato.Print()
    End Sub

    Private Sub Dbut_Click(sender As Object, e As EventArgs) Handles Dbut.Click, Dbut.Click, Dbut.Click

    End Sub
End Class
