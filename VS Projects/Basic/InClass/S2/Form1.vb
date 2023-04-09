Public Class Form1
    Sub Sum(X As Double, Y As Double)
        Output.Text += X & " + " & Y & " = " & (X + Y).ToString() & vbCrLf 'Outputs Addition operation
    End Sub
    Sub Mut(X As Double, Y As Double)
        Output.Text += X & " * " & Y & " = " & (X * Y).ToString() & vbCrLf  'Outputs Multiplication operation
    End Sub
    Sub Dv(X As Double, Y As Double)
        Output.Text += X & " / " & Y & " = " & (X / Y).ToString() & vbCrLf  'Outputs Division operation
    End Sub
    Sub Mit(X As Double, Y As Double)
        Output.Text += X & " - " & Y & " = " & (X - Y).ToString() & vbCrLf  'Outputs Difference or Subtraction
    End Sub
    Sub MTable(Num As Double)
        Dim Calcs As Double
        For Index = 0 To Num
            Calcs = Index * Num
            Output.Text += Index & " " & Num & " " & Calcs & vbCrLf     'Outputs Multiplication Table
        Next

    End Sub
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Sum(10, 5)      'Onload Calls the Sum sub program
        Mut(5, 20)      'Onload Calls the Mut sub program
        Dv(10, 5)       'Onload Calls the DV sub program
        Mit(10, 5)      'Onload Calls the Mit sub program
        MTable(10)      'Onload Calls the MTable sub program
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Num1.Text > "" And Num2.Text > "") Then     'evaluates text boxes for values
            Sum(Num1.Text, Num2.Text)                   'sends values in Num1, Num2 to Sub sub
        Else
            Sum(55, 20)                                 'Sends Default values to Sum sub
        End If

    End Sub

    Private Sub CBut_Click(sender As Object, e As EventArgs) Handles CBut.Click
        Output.Clear()              'Clearin values
        Num1.Clear()                'Clearin values
        Num2.Clear()                'Clearin values
    End Sub

    Private Sub Mutten_Click(sender As Object, e As EventArgs) Handles Mutten.Click
        If (Num1.Text > "" And Num2.Text > "") Then         'Evaluates values in Num1, Num2
            Mut(Num1.Text, Num2.Text)           'sends values to Mut sub
        Else
            Mut(55, 20)                         'sends defaults to Mut sub
        End If
    End Sub

    Private Sub DVb_Click(sender As Object, e As EventArgs) Handles DVb.Click
        If (Num1.Text > "" And Num2.Text > "") Then     'Evaluates valuse of Num1, Num2 
            Dv(Num1.Text, Num2.Text)                    'sends values to Dv sub
        Else
            Dv(55, 20)                                  'sends defaults to Dv
        End If
    End Sub

    Private Sub Minty_Click(sender As Object, e As EventArgs) Handles Minty.Click
        If (Num1.Text > "" And Num2.Text > "") Then     'Evaluates values of Num1, Num2
            Mit(Num1.Text, Num2.Text)                   'sends values to Mit sub
        Else
            Mit(55, 20)                             'sends defaults to Mit sub
        End If
    End Sub

    Private Sub Mtab_Click(sender As Object, e As EventArgs) Handles Mtab.Click
        If (Num1.Text > "" And Num2.Text = "") Then     'Evaluates values Num1, Num2
            MTable(Num1.Text)                   'sends value of Num1 to MTable sub
        ElseIf (Num1.Text = "" And Num2.Text > "") Then     'evaluates values of Num1, Num2
            MTable(Num2.Text)               'sends value of Num2 to MTable sub
        ElseIf (Num1.Text > "" And Num2.Text > "") Then 'evaluates values of Num1, Num2
            MTable(Num1.Text)       'sends value of N1 to Mtable sub
            Output.Text += vbCrLf   'Line feed
            MTable(Num2.Text)       'sends value of N2 to Mtable sub
            Output.Text += vbCrLf   'Line feed
        End If
    End Sub
End Class
