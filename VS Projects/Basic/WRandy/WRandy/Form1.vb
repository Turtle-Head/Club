Public Class Form1
    Private Sub ActNow_Click_1(sender As Object, e As EventArgs) Handles ActNow.Click
        Randomize()
        If (Num.Text = Nothing) Then
            Num.Text = "20"
        End If
        Dim N1 = Num.Text           'Gets Number for randomize calculation
        Dim N2 = 0                  'Variable that gets random Number
        OptBox.Clear()  'clear results

        While (N1 <> N2)            'Runs code while n1 doesn't = the random number
            N2 = Int(N1 * Rnd() + 1)        'get random number
            If (N2 = N1) Then               'checks for end while conditions
                OptBox.Text += N2.ToString() & vbCrLf   'outputs final number seperating the end number with line feed
            Else
                OptBox.Text += N2.ToString() & ", "     'outputs random numbers
            End If
        End While

    End Sub

    Private Sub ClrB_Click_1(sender As Object, e As EventArgs) Handles ClrB.Click
        OptBox.Clear()  'clear results
        Num.Clear()     'clears Initial Number
    End Sub

End Class
