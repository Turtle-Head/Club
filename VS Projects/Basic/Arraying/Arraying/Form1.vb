﻿Public Class Form1

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click  'Total Button Click event
        Dim AnExercise() As Integer = {5, 1, 22, 4, 3}                              'create array of 5 integers
        Dim Sum As Integer = AnExercise(0) + AnExercise(1) + AnExercise(2) + AnExercise(3) + AnExercise(4)  'sum the integers without loop
        Opt1.Text = Sum                                     'Output array sum to textbox Opt1
        MessageBox.Show("The Sum of the array is " & Sum)   'Output sum of array to a messagebox
    End Sub

    Private Sub NTot_Click_1(sender As Object, e As EventArgs) Handles NTot.Click  'New Total event click 
        Dim B() As Integer = {1, 5, 8, 0, 19, 4, 6, 15, 10, 13}                     ' create a new array
        Dim C As Integer = 0                                                        'create var to handle operations
        Dim D As Integer = 0                                                        'create var to handle operations
        Dim F As Integer = 0                                                        'create var to handle operations
        Dim G As Integer = 0                                                        'create var to handle operations
        Dim H As Integer = 0                                                        'create var to handle operations
        Dim Sum As Integer = 0                                                      'create var to handle operations
        For Index = 0 To B.GetUpperBound(0)             'Use loop to access array

            If (B(Index) = 0) Then                      'count zeros
                C += 1 'counts zeros
            End If
            If (B(Index) Mod 2 = 0) Then                'count even numbers
                D += 1  'counts even numbers
                G += B(Index)
            End If
            If (B(Index) Mod 2 <> 0) Then               'count odd numbers
                F += 1  'counts odd numbers
                H += B(Index)
            End If

        Next

        Otp2.Text = "There are = " & C.ToString & " Zeros" & vbCrLf     'output string
        Otp2.Text += " Even Numbers: " & D.ToString & vbCrLf         'output string
        Otp2.Text += " Odd Numbers: " & F.ToString() & vbCrLf        'output string
        Otp2.Text += " Even Sum = " & G.ToString() & vbCrLf          'output string
        Otp2.Text += " Odds Sum = " & H.ToString() & vbCrLf          'output string
        Otp2.Text += "The Array:" & vbCrLf                               'output string with Heading for array
        For Index = 0 To B.GetUpperBound(0)                             'initialize for loop
            Otp2.Text += B(Index) & ", "                                 'outputs array values
        Next
        For Index = 0 To B.GetUpperBound(0)                         'initialize fro loop
            Sum += B(Index)                                         'sum all numbers in array
        Next
        Otp2.Text += vbCrLf & "Sum of array = " & Sum & vbCrLf      'outputs Sum to Otp2 RichTextBox

    End Sub

    Private Sub RNum_Click(sender As Object, e As EventArgs) Handles RNum.Click     'Event handler for Exercise 3 button
        Randomize()
        Dim C As Integer = 0        'create var to handle operations
        Dim D As Integer = 0        'create var to handle operations
        Dim F As Integer = 0        'create var to handle operations
        Dim G As Integer = 0        'create var to handle operations
        Dim H As Integer = 0        'create var to handle operations
        Dim Big As Integer          'create var to handle operations
        Dim Sml As Integer          'create var to handle operations
        Dim RNum(101) As Integer    'create an array of 100 integer
        For Index = 0 To 101
            RNum(Index) = Int(101 * Rnd() + 1)  'add random numbers to RNum array
        Next
        Otp2.Text = "The Array:" & vbCrLf
        For Index = 0 To RNum.GetUpperBound(0)  'Output array values to Otp2 RichTextBox
            Otp2.Text += RNum(Index) & ", "
        Next
        For Index = 0 To RNum.GetUpperBound(0)
            Big = RNum(0)
            If (RNum(Index) = 0) Then
                C += 1 'counts zeros
            End If
            If (RNum(Index) Mod 2 = 0) Then
                D += 1  'counts even numbers
                G += RNum(Index)
            End If
            If (RNum(Index) Mod 2 <> 0) Then
                F += 1  'counts odd numbers
                H += RNum(Index)
            End If
        Next
        Otp2.Text += vbCrLf & "There are: " & C.ToString & " Zeros" & vbCrLf         'output string
        Otp2.Text += " Even Numbers: " & D.ToString & vbCrLf                         'output string
        Otp2.Text += " Odd Numbers: " & F.ToString() & vbCrLf                       'output string
        Otp2.Text += " Even sum = " & G.ToString() & vbCrLf                         'output string
        Otp2.Text += " Odds sum = " & H.ToString() & vbCrLf                          'output string
        Big = RNum(0)                                           'sets Biggest number as the first item in array
        For Index = 0 To RNum.GetUpperBound(0)
            If ((Index + 1) < RNum.GetUpperBound(0)) Then   'checks to make sure we don't go outofbounds
                If (RNum(Index) > RNum(Index + 1)) And (Big < RNum(Index)) Then         'checks for largest number
                    Big = RNum(Index)                           'gets current largest number
                End If
            End If
        Next
        Otp2.Text += " Biggest Number: " & Big.ToString() & vbCrLf
        Sml = RNum(0)                                           'sets Smalles number as first item in array
        For Index = 0 To RNum.GetUpperBound(0)
            If ((Index + 1) < RNum.GetUpperBound(0)) Then 'checks to make sure we don't go outofbounds
                If (RNum(Index) < RNum(Index + 1)) And (Sml > RNum(Index)) Then         'checks for smallest number
                    Sml = RNum(Index)                           'gets current smalles number
                End If
            End If
        Next
        Otp2.Text += " Smallest Number: " & Sml.ToString() & vbCrLf     'outputs Smallest number
        Dim SuT As Integer = 0
        For Index = 0 To RNum.GetUpperBound(0)
            SuT += RNum(Index)                                          'adds all random numbers
        Next
        Otp2.Text += "Sum of numbers = " & SuT.ToString() & vbCrLf              'outputs sum of all random numbers
        Dim Avg As Integer = (SuT / RNum.Length)                                'calculates average
        Otp2.Text += "Average = " & Avg.ToString() & vbCrLf                     'outputs average
    End Sub

End Class
