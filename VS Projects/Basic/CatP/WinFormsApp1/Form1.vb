Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub cct_Click(sender As Object, e As EventArgs) Handles cct.Click
        Result.Text = Pname.Text + " " + theMessage.Text
        theMessage.BackColor = Color.CadetBlue
        theMessage.ForeColor = Color.Gold
        Pname.BackColor = Color.CadetBlue
        Pname.ForeColor = Color.Gold
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        theMessage.BackColor = Color.LightCyan
        theMessage.ForeColor = Color.Black
        Pname.BackColor = Color.LightCyan
        Pname.ForeColor = Color.Black
        theMessage.Text = ""
        Pname.Text = "Merlin the Magnificient"
        Result.Text = ""
    End Sub
End Class
