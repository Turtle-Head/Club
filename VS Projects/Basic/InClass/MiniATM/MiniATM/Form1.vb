Public Class Form1
    Public B As Double = Bala()
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ' Make a Mini-ATM.
        '•Using a function And subroutine, use the
        'Function to() Return the amount withdrawn As a messagebox. Use the subroutine To print the balance
        'in a message box. Print the balance when after you withdraw
        '•Output Is on the next page, but feel free
        'to use your own design
    End Sub

    Function Bala()
        Randomize()
        Dim RNum(1000) As Integer    'create an array of 100 integer
        Dim Bal As Double = 0
        For Index = 0 To 1000
            RNum(Index) = Int(1000 * Rnd() + 1)  'add random numbers to RNum array
        Next
        For Index = 0 To RNum.GetUpperBound(0)  'Sum the Array of Random Numbers to create a Balance to use
            Bal += RNum(Index)                  'Sum the Array of Random Numbers to create a Balance to use
        Next
        Return (Bal)                            'Return Balance
    End Function
    Private Sub BalCheck_Click(sender As Object, e As EventArgs) Handles BalCheck.Click
        Balance.Text = B.ToString               'Get Balance from Global storage
        MessageBox.Show(B.ToString)             'Show Balance
    End Sub

    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles Withdraw.Click
        If (Amount.Text > "") Then          'If Amount to withdraw is a value
            MessageBox.Show(B.ToString & " - Withdrawl: " & Amount.Text & vbCrLf)   'Show Withdrawl message
            B -= Amount.Text                                                        'Withdraw Money
            MessageBox.Show("Balance: " & B.ToString)                               'Show Balance
            Output.Text += vbCrLf & "Withdrawl: " & Amount.Text & vbCrLf            'Show activity of acount
            Balance.Text = B.ToString                                               'Show Balance Updated
            Output.Text += vbCrLf & "Balance: " & B.ToString                        'Show Balance Updated


        End If
    End Sub

    Private Sub Depo_Click(sender As Object, e As EventArgs) Handles Depo.Click
        If (Amount.Text > "") Then          'If Amount to deposit is a value
            MessageBox.Show(B.ToString & " Deposit: " & Amount.Text)    'Show Operation 
            B += Amount.Text                                            'Deposit Money
            MessageBox.Show(B.ToString)                                 'Show Updated Balance
            Output.Text += vbCrLf & "Deposit: " & Amount.Text & vbCrLf  'Show Deposit Operation
            Balance.Text = B.ToString                                   'Show Updated Balance
            Output.Text += vbCrLf & "Balance: " & B.ToString            'Show Updated Balance


        End If
    End Sub

    Private Sub Clr_Click(sender As Object, e As EventArgs) Handles Clr.Click
        Output.Clear()                      'Clear RichTextBox "Output"
        Balance.Clear()                     'Clear "Balance" TextBox
        Amount.Clear()                      'Clear "Amount" TextBox
        Balance.Text = B.ToString           'Show Current Balance

    End Sub
End Class
