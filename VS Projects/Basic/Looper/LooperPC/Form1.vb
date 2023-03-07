Imports System.Xml.Schema

Public Class Form1
    Private Sub BAction_Click_1(sender As Object, e As EventArgs) Handles BAction.Click
        Dim index As Integer                'Initialize variable
        Dim Result = 0                      'Initialize variable
        Dim N1, N2 As String                'Initialize variables
        'Error checking that numbers are in Textboxs
        If (Num1.Text <> Nothing) Then
            N1 = Num1.Text                  'Initialize variable
        Else
            Num1.Text = "1"                     'Initialize variable
            N1 = Num1.Text                  'Initialize variable
        End If
        If (Num2.Text <> Nothing) Then
            N2 = Num2.Text                  'Initialize variable
        Else
            Num2.Text = "9"                     'Initialize variable
            N2 = Num2.Text                  'Initialize variable
        End If
        DisplayResult.Clear()
        For index = N1 To N2                'Initialize For Loop
            If (index <> N2) Then
                DisplayResult.Text += index.ToString() & ","        'Storing Index value and "," as output
                Result += index                 'Sums index value for later
            Else
                DisplayResult.Text += index.ToString()        'Storing Index value and "," as output
                Result += index                 'Sums index value for later
            End If
        Next
        DisplayResult.Text += vbCrLf & N1 & " : " & N2 & " = " & Result.ToString() & vbCrLf     'Displays Sum or index 
    End Sub

    Private Sub ClResultR_Click_1(sender As Object, e As EventArgs) Handles ClResultR.Click
        DisplayResult.Text = "Please Enter Two Numbers"      'Clears output

    End Sub

    Private Sub ResetB_Click_1(sender As Object, e As EventArgs) Handles ResetB.Click
        Num1.Clear()                'Clears Number value
        Num2.Clear()                'Clears Number value
        DisplayResult.Text = "Please Enter Two Numbers"      'Clears output
    End Sub

    Private Sub EVB_Click(sender As Object, e As EventArgs) Handles EVB.Click
        Dim index As Integer                'Initialize variable
        Dim Result = 0                      'Initialize variable
        Dim N1, N2 As String
        'Error checking that numbers are in Textboxs
        If (Num1.Text <> Nothing) Then
            N1 = Num1.Text                  'Initialize variable
        Else
            Num1.Text = "1"                     'Initialize variable
            N1 = Num1.Text                  'Initialize variable
        End If
        If (Num2.Text <> Nothing) Then
            N2 = Num2.Text                  'Initialize variable
        Else
            Num2.Text = "9"                 'Initialize variable
            N2 = Num2.Text                  'Initialize variable
        End If
        DisplayResult.Clear()
        For index = N1 To N2                'Initialize For Loop
            If (index Mod 2 = 0) Then
                If (index <> N2) Then
                    DisplayResult.Text += index.ToString() & ","        'Storing Index value and "," as output
                    Result += index                 'Sums index value for later
                Else
                    DisplayResult.Text += index.ToString()        'Storing Index value and "," as output
                    Result += index                 'Sums index value for later
                End If
            End If
        Next
        DisplayResult.Text += vbCrLf & N1 & " : " & N2 & " = " & Result.ToString() & vbCrLf     'Displays Sum or index 
    End Sub

    Private Sub OddB_Click(sender As Object, e As EventArgs) Handles OddB.Click
        Dim index As Integer                'Initialize variable
        Dim Result = 0                      'Initialize variable
        Dim N1, N2 As String                'Initialize variable
        'Error checking that numbers are in Textboxs
        If (Num1.Text <> Nothing) Then
            N1 = Num1.Text                  'Initialize variable
        Else
            Num1.Text = "1"                     'Initialize variable
            N1 = Num1.Text                  'Initialize variable
        End If
        If (Num2.Text <> Nothing) Then
            N2 = Num2.Text                  'Initialize variable
        Else
            Num2.Text = "9"                     'Initialize variable
            N2 = Num2.Text                  'Initialize variable
        End If
        DisplayResult.Clear()
        For index = N1 To N2                'Initialize For Loop
            If (index Mod 2 <> 0) Then
                If (index <> N2) Then
                    DisplayResult.Text += index.ToString() & ","        'Storing Index value and "," as output
                    Result += index                 'Sums index value for later
                Else
                    DisplayResult.Text += index.ToString()        'Storing Index value and "," as output
                    Result += index                 'Sums index value for later
                End If
            End If
        Next
        DisplayResult.Text += vbCrLf & n1 & " : " & n2 & " = " & Result.ToString() & vbCrLf     'Displays Sum or index 
    End Sub

    Private Sub Pchk_Click(sender As Object, e As EventArgs) Handles Pchk.Click

        Dim N1, N2 As String
        'Error checking that numbers are in Textboxs
        If (Num1.Text <> Nothing) Then
            N1 = Num1.Text                  'Initialize variable
        Else
            Num1.Text = "2"                     'Initialize variable
            N1 = Num1.Text                  'Initialize variable
        End If
        If (Num2.Text <> Nothing) Then
            N2 = Num2.Text                  'Initialize variable
        Else
            Num2.Text = "6"                     'Initialize variable
            N2 = Num2.Text                  'Initialize variable
        End If
        DisplayResult.Clear()
        If ((N1 = "1") And (N2 = "1")) Then
            DisplayResult.Text = "There are no Prime Numbers"   'Tells the user the values are not Prime numbers
        ElseIf ((N1 = "1") And (N2 Mod 2 <> 0)) Or (N2 = "2") Then
            DisplayResult.Text = "Prime: " & N2.ToString()      'outputs prime number
        ElseIf ((N1 Mod 2 <> 0) And (N2 = "1")) Or (N1 = "2") Then
            DisplayResult.Text = "Prime: " & N1.ToString() & " True"     'outputs prime number
        ElseIf ((N1 Mod 2 <> 0) And (N2 Mod 2 <> 0)) Or ((N1 = "2") And (N2 = "2")) Then 'checks if both are prime
            DisplayResult.Text = "Prime: " & N1.ToString() & "," & N2.ToString() & "True"    'outputs prime numbers
        ElseIf (N1 Mod 2 <> 0) And (N2 Mod 2 = 0) And (N1 = "2") Then          'checks for Prime
            DisplayResult.Text = "Prime: " & N1.ToString()      'outputs prime number
        ElseIf (N2 Mod 2 <> 0) And (N1 Mod 2 = 0) And (N2 = "2") Then          'checks for Prime
            DisplayResult.Text = "Prime: " & N2.ToString() & "True"     'outputs prime number
        ElseIf (N1 = "2") Or (N2 Mod 2 = 0) Then
            DisplayResult.Text = "Prime: " & N1.ToString() & "True"       'outputs prime number
        ElseIf (N1 Mod 2 = 0) And (N2 = "2") Then
            DisplayResult.Text = "Prime: " & N2.ToString() & "True"       'outputs prime number
        Else
            DisplayResult.Text = "There are no Prime Numbers"   'Tells the user the values are not Prime numbers
        End If

    End Sub
End Class
