
Public Class Form1
    Sub Print(Spn As String)
        Dim GMe As String = GrabMe.Text     'Gets value of GrabMe Textbox

        If (GMe > "" And Spn > "") Then     'Evaluates GMe, Spn values
            Output.Text += Spn & GMe & vbCrLf   'Outputs Spn and GMe then Line Feed
        ElseIf (Spn > "" And GMe <> "") Then    'Evaluates Spn, GMe values
            Output.Text += Spn & GMe        'Outputs Spn and GMe
        Else
            Output.Text += "Hello Sub! "
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Print(" Button.Click()")    'sends a string to Print sub
        GrabMe.Clear()          'Clears textbox GrabMe

    End Sub



    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Print("Button Click")       'sends string to Print sub
    End Sub

    Private Sub ClrButton_Click(sender As Object, e As EventArgs) Handles ClrButton.Click
        Output.Clear()      'Clears Output
        GrabMe.Clear()      'Clears GrabMe
    End Sub
End Class