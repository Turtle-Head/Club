Public Class Form1
    Function Bigg(Rnum() As Integer)
        Dim Big As Integer = Rnum(0)                 'sets Biggest number as the first item in array
        For Index = 0 To Rnum.GetUpperBound(0)
            If ((Index + 1) < Rnum.GetUpperBound(0)) Then   'checks to make sure we don't go outofbounds
                If (Rnum(Index) > Rnum(Index + 1)) And (Big < Rnum(Index)) Then  'checks for largest number
                    Big = Rnum(Index)                           'gets current largest number
                End If
            End If
        Next
        Return (Big)
    End Function

    Function Smaller(RNum() As Integer)
        Dim Sml = RNum(0)                                           'sets Smalles number as first item in array
        For Index = 0 To RNum.GetUpperBound(0)
            If ((Index + 1) < RNum.GetUpperBound(0)) Then 'checks to make sure we don't go outofbounds
                If (RNum(Index) < RNum(Index + 1)) And (Sml > RNum(Index)) Then         'checks for smallest number
                    Sml = RNum(Index)                           'gets current smalles number
                End If
            End If
        Next
        Return (Sml)
    End Function

    Function Tots(RNum() As Integer)
        Dim SuT As Integer = 0
        For Index = 0 To RNum.GetUpperBound(0)
            SuT += RNum(Index)                                          'adds all random numbers
        Next
        Return (SuT)
    End Function

    Function Zerox(RNum() As Integer)
        Dim C As Integer = 0        'create var to handle operations
        For Index = 0 To RNum.GetUpperBound(0)
            If (RNum(Index) = 0) Then
                C += 1 'counts zeros
            End If
        Next
        Return (C)
    End Function
    Function ODs(RNum() As Integer)
        Dim H As Integer = 0        'create var to handle operations
        For Index = 0 To RNum.GetUpperBound(0)
            If (RNum(Index) Mod 2 <> 0) Then
                H += RNum(Index)
            End If
        Next
        Return (H)
    End Function

    Function CODs(RNum() As Integer)
        Dim F As Integer = 0        'create var to handle operations
        For Index = 0 To RNum.GetUpperBound(0)
            If (RNum(Index) Mod 2 <> 0) Then
                F += 1  'counts odd numbers
            End If
        Next
        Return (F)
    End Function
    Function Evens(RNum() As Integer)
        Dim G As Integer = 0        'create var to handle operations
        For Index = 0 To RNum.GetUpperBound(0)
            If (RNum(Index) Mod 2 = 0) Then
                G += RNum(Index)
            End If
        Next
        Return (G)
    End Function

    Function CEven(RNum)
        Dim D As Integer = 0        'create var to handle operations
        For Index = 0 To RNum.GetUpperBound(0)
            If (RNum(Index) Mod 2 = 0) Then
                D += 1  'counts even numbers
            End If
        Next
        Return (D)
    End Function
    Sub Rsp()
        Randomize()
        Dim RNum(101) As Integer    'create an array of 100 integer
        For Index = 0 To 101
            RNum(Index) = Int(101 * Rnd() + 1)  'add random numbers to RNum array
        Next
        Output.Text = "The Array:" & vbCrLf
        For Index = 0 To RNum.GetUpperBound(0)  'Output array values to Otp2 RichTextBox
            Output.Text += RNum(Index) & ", "
        Next
        Output.Text += vbCrLf
        Output.Text += "There are: " & Zerox(RNum) & " Zeros" & vbCrLf         'output string
        Output.Text += " Even Numbers: " & CEven(RNum) & vbCrLf                         'output string
        Output.Text += " Odd Numbers: " & CODs(RNum) & vbCrLf                       'output string
        Output.Text += " Even sum = " & Evens(RNum) & vbCrLf                         'output string
        Output.Text += " Odds sum = " & ODs(RNum) & vbCrLf                          'output string
        Dim Bigger As Integer = Bigg(RNum)
        Output.Text += " Biggest Number: " & Bigger.ToString() & vbCrLf
        Dim Smallest As Integer = Smaller(RNum)
        Output.Text += " Smallest Number: " & Smallest.ToString() & vbCrLf        'outputs Smallest number
        Dim Som As Integer = Tots(RNum)                                         'Gets sum of array
        Output.Text += "Sum of numbers = " & Som.ToString() & vbCrLf              'outputs sum of all random numbers
        Dim Avg As Integer = (Som / RNum.Length)                                'calculates average
        Output.Text += "Average = " & Avg.ToString() & vbCrLf                     'outputs average
    End Sub

    Private Sub Rondo_Click(sender As Object, e As EventArgs) Handles Rondo.Click
        Rsp()
    End Sub
End Class