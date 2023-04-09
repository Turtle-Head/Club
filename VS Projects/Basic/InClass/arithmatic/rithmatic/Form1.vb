Public Class Form1
    Function Arith(Num1 As Double, Num2 As Double, Oprat As String)
        If (Oprat = "+" Or Oprat = "-" Or Oprat = "*" Or Oprat = "/" Or Oprat = "%") Then   'check operator
            If (Oprat = "*") Then       'Check oprat for arithmatic operator
                Return (Num1 * Num2)    'Returns the variables multiplied as a result
            ElseIf (Oprat = "+") Then   'Check oprat for arithmatic operator
                Return (Num1 + Num2)    'Returns the variables multiplied as a result
            ElseIf (Oprat = "-") Then   'Check oprat for arithmatic operator
                Return (Num1 - Num2)    'Returns the variables multiplied as a result
            ElseIf (Oprat = "/") Then   'Check oprat for arithmatic operator
                Return (Num1 / Num2)    'Returns the variables divided as a result
            ElseIf (Oprat = "%") Then   'Check oprat for arithmatic operator
                Return (Num1 Mod Num2)  'Returns the variables Mod as a result
            End If
        End If

    End Function

    Private Sub ClkMe_Click(sender As Object, e As EventArgs) Handles ClkMe.Click
        If (Num1.Text <> "" And Num2.Text <> "" And Op.Text <> "") Then
            Dim Result As String = Arith(Num1.Text, Num2.Text, Op.Text) 'Get Result for numbers with operator
            Output.Text = Result    'Display Result of Arithmatic used
        End If
    End Sub

    Private Sub ClrB_Click(sender As Object, e As EventArgs) Handles ClrB.Click
        Num1.Clear()
        Num2.Clear()
        Output.Clear()
        Op.Clear()
    End Sub
End Class
