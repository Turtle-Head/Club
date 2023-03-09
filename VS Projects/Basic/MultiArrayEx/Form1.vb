Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Months() As String = {'"0123456789",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"}
        For Index = 0 To Months.GetUpperBound(0)
            For innerIndex = 0 To Months(Index).Length - 1
                Otp1.Text += Months(Index)(innerIndex) & " - "
            Next
            Otp1.Text += vbCrLf
        Next
    End Sub

End Class
