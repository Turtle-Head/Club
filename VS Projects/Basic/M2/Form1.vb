Imports System.Reflection.Metadata
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form1
    'Author: James Fehr 2023-03-09
    'Classwork ITD Canada 
    Dim GBA(,) As String ' = {{"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}} 'array of Os

    Sub PrintBoard()
        Output1.Clear()
        For Index = 0 To GBA.GetUpperBound(0)                       'starting for loop
            For innerIndex = 0 To GBA.GetUpperBound(1)           'run loop from zero => length of array
                Output1.Text += GBA(Index, innerIndex)              'output array value
                ' Output1.Text += vbCrLf
            Next
            Output1.Text += vbCrLf                                  'add a line return to output 
        Next

    End Sub

    Private Sub Ex1_Click(sender As Object, e As EventArgs) Handles Ex1.Click, Ex1.Click
        '-= Exercise 1=-
        'Using a multidimensional array populate(fill up)
        'the array and print out a 5 x 5 tile board like
        'the one below into a rich textbox
        '{"ⓞ ⓞ ⓞ ⓞ ⓞ", "Ⓧ Ⓧ Ⓧ Ⓧ Ⓧ", "* * * * *", "* * * * *", "* * * * *"}ⓞⓍ


        GBA = New String(4, 4) {{"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}, {"ⓞ", "ⓞ", "ⓞ", "ⓞ", "ⓞ"}} 'array of Os
        PrintBoard()
        'MessageBox.Show(Output1.Text)                              'Message the output value for user

    End Sub
    Private Sub Fire_Click(sender As Object, e As EventArgs) Handles Fire.Click
        Dim Xval As Integer
        Xval = (Convert.ToInt32(Xv.Text))       'gets and converts values to integers
        Dim Yval As Integer
        Yval = (Convert.ToInt32(Yv.Text))       'gets and converts values to integers
        If ((Xval And Yval > 0) And (Xval And Yval <= 4)) Then  'checks to see if x,y coordinates are in bounds
            GBA(Yval, Xval) = "Ⓧ"       'if in bounds changes item in array to hit
        ElseIf (Xval > 4) Then     'checks if out of bounds
            MessageBox.Show("Out of bounds")
            Xv.Text = ""                        'resets Xv coordinate
            'Yv.Text = ""                        'resets Yv coodinate
        ElseIf (Yval > 4) Then     'checks if out of bounds
            MessageBox.Show("Out of bounds")
            'Xv.Text = ""                        'resets Xv coordinate
            Yv.Text = ""                        'resets Yv coodinate
        End If
        PrintBoard()
    End Sub
    Private Sub Ex2_Click(sender As Object, e As EventArgs) Handles Ex2.Click, Ex2.Click, Ex2.Click
        '--------------------------------------------------------------------------------------------------
        '        -= Exercise 2=-
        '        Create a program that has an array of names. When the program runs calculate how
        '        many times the name Is repeated.

        '        Input = {John, Sam, Jen, Bob, Carry, Eugine, John}

        '        The
        '       output will be

        '        Name
        '           John: 2 times
        '        If there Is only one name you will have to output
        '
        '        Name
        '           John: 1 time
        '--------------------------------------------------------------------------------------------------
        Dim Ninput() As String = {"John", "Sam", "Jen", "Bob", "Carry", "Eugine", "John"}
        Dim cnt As Integer = 0  'counter variable that is outside of the loop
        Output1.Clear()                                 'clears output RichTextBox
        For index = 0 To Ninput.GetUpperBound(0)        'checking for "John" in array
            If (Ninput(index) = "John") Then            'checking for "John" in array
                cnt += 1                                'found John +1 to cnt for the discovery
                Output1.Text += " " & Ninput(index) & " " & cnt & " time" & vbCrLf      'output " John 1 time, NewLine
            Else
                Output1.Text += " " & Ninput(index) & " " & vbCrLf 'this output current array item can add linefeed to display column of names 
            End If
        Next
        'MessageBox.Show(Output1.Text)

    End Sub

    Private Sub Ex3_Click(sender As Object, e As EventArgs) Handles Ex3.Click
        '----------------------------------------------------------------------------------------------
        '       -= Exercise 3 =-
        '       Convert a string to camel case
        '   Input
        '       = “Be kind to people”
        '   Output
        '       = “beKindToPeople”
        '
        '   Look up:
        '   1.Split()
        '   2.Substring()
        '   3.Upper()
        '   4.ToLower()
        '----------------------------------------------------------------------------------------------
        Dim Phrase As String = “May the force be with you”      ' Phrase holds {“Be kind to people"}
        Dim testArray() As String = Split(Phrase)       'splits the string into an array

        Dim lastNonEmpty As Integer = -1                'used in checking for spaces etc
        For i As Integer = 0 To testArray.Length - 1    'empties spaces from the string
            If testArray(i) <> "" Then              'checks to ensure array has populated
                lastNonEmpty += 1
                testArray(lastNonEmpty) = testArray(i)  'fills array with the string values seperated by spaces
            End If
        Next
        ReDim Preserve testArray(lastNonEmpty)  'adjusting size of array
        ' testArray now holds {"Be", "kind", "to", "people"}

        testArray(0) = testArray(0).ToLower()   'lower case change of first array value to all lowercase
        Output1.Text = testArray(0)             'outputs first value of array
        For i As Integer = 1 To testArray.GetUpperBound(0)      'Sets up array to be combied in CamelCase
            If testArray(i).Length > 0 Then
                testArray(i) = testArray(i).Substring(0, 1).ToUpper() + testArray(i).Substring(1).ToLower()     'changing case of array values
            ElseIf testArray(i).Length = 1 Then
                testArray(i) = testArray(i).ToUpper()       'changes the case of the array valuie
            End If
            Output1.Text += testArray(i)            'outputs camelCase array that used to be a string
        Next

    End Sub


End Class
