Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports ADODB
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.Diagnostics

Public Class Form1
    Dim Business(20) As PictureBox                  'Array of Business class seats
    Dim myImageLocationPrefix As String = "C:\Users\Stark\Documents\Documents\GitHub\VS Projects\Basic\InClass\AirBus\AirBus\bin\Debug\net6.0-windows\"
    Dim EmptySeatImg As String = "empSeat.png"      'Name of Empty Seat picture
    Dim FullSeatImg As String = "seatReserved.png"  'Name of Full Seat picture
    Dim Economy(100) As PictureBox                  'Array of Economy class seats
    Dim LocBusiness(20) As RichTextBox              'Array of Textboxes to line up with Business array
    Dim LocEc(100) As RichTextBox                   'Array of Terxtboxes to line up with Economy
    Dim ClickedBox As PictureBox                    'Instance of Clicked seat
    Dim CurrentPassenger As Integer = 0             'Seat number regardless of B or E class, always partnered up with either Business or Economy array
    Dim ConObj As SqlConnection                     'Set up connection to SQL server
    Dim Names(2) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load        'Loads page, tabs and buttons
        '-------------Load SQL Server-----
        ConObj = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Stark\Documents\Documents\GitHub\VS Projects\Basic\InClass\AirBus\AirBus\Eco.mdf';Integrated Security=True")
        ConObj.Open()
        '----------------------------------Load  SQL above---------------------------------------------
        Dim xLocation As Integer = 10                                                   'X location for PictureBox
        Dim yLocation As Integer = 10                                                   'Y location for PictureBox
        For Index = 0 To 19                                                             'Add Business Class seats
            Business(Index) = New PictureBox() With {                                   'Type of object PictureBox 
            .ImageLocation = EmptySeatImg,                      'Location of image
            .Size = New Drawing.Size(200, 200),                                         'Image size
            .Location = New Point(xLocation, yLocation),                                'Image location
            .Name = "Biz" & Index.ToString(),                                    'Seat Number & Name added to array 
            .Visible = True,                                                            'Image is Visible
            .Enabled = True,                                                            'Image is Enabled
            .Cursor = Cursors.Hand                                                      'Use the Hand Cursor for clicks
            }
            TabPage1.Controls.Add(Business(Index))                                      'Populate TabPage1 with Business Class seats
            AddHandler Business(Index).Click, AddressOf PictureBoxClick                 'Add Click Event
            LocBusiness(Index) = New RichTextBox With {                                 'Add RichTextBox below the Image
                .Name = Index.ToString() & "Business",                                  'Add Seat Number & Name to Textbox
                .Visible = True,                                                        'Textbox is visible
                .Enabled = True,                                                        'Textbox is Enabled
                .Cursor = Cursors.Hand,                                                 'Use the Hand Cursor
                .Size = New Drawing.Size(200, 150),                                     'Size of Textbox
                .Location = New Point(xLocation, yLocation + 200)                       'Location of Textbox
            }
            TabPage1.Controls.Add(LocBusiness(Index))                                   'populate TabPage1 with RichTextBoxes
            xLocation += 210                                                            'Adjust X position for next Image and RTB
            If (Index + 1) Mod 4 = 0 Then                                               'Align X and Y for Next Image and RTB
                xLocation = 10
                yLocation += 410
            End If
        Next
        xLocation = 10                                                                  'X location for PictureBox
        yLocation = 10
        '=-------------------------Sql----------------------------------
        Dim Cmd1 As New SqlCommand($"SELECT * FROM Bus;", ConObj)                       'Load values from Bus Table
        Dim reader As SqlDataReader

        reader = Cmd1.ExecuteReader
        If reader.HasRows = False Then
            reader.Close()
            Return
        End If
        While reader.Read
            Dim seat As Integer = Convert.ToInt32(reader.GetValue(0))
            Names(0) = reader.GetValue(1).ToString()
            Names(1) = reader.GetValue(2).ToString()
            Business(seat).ImageLocation = FullSeatImg
            LocBusiness(seat).Text = $"{Names(0) & " " & Names(1)}"
        End While
        reader.Close()
        '-----------------------------------Sql Above for Business------------------------------------------

        For Index = 0 To 99                                                             'Set up Economy Class seats
            Economy(Index) = New PictureBox() With {                                    'Array of PictureBoxes
            .ImageLocation = EmptySeatImg,                      'Image address for Empty seat
            .Size = New Drawing.Size(200, 200),                                         'Size of Image
            .Location = New Point(xLocation, yLocation),                                'Location of Image
            .Name = "Eco" & Index.ToString(),                                      'Seat Number & Name
            .Visible = True,                                                            'Image is Visible
            .Enabled = True,                                                            'Image is Enabled
            .Cursor = Cursors.Hand                                                      'Use Hand Cursor
            }
            TabPage2.Controls.Add(Economy(Index))                                       'Add Economy Seats to TabPage2
            AddHandler Economy(Index).Click, AddressOf PictureBoxClick                  'Add Click Event for Images
            LocEc(Index) = New RichTextBox With {                                       'Add RichTextBox to line up below Image
                .Name = Index.ToString() & " Economy",                                  'Seat Number & Name
                .Visible = True,                                                        'RichTextBox is Visible
                .Enabled = True,                                                        'RTB is Enabled
                .Cursor = Cursors.Hand,                                                 'Use Hand Cursor
                .Size = New Drawing.Size(200, 150),                                     'Size of RichTextBox
                .Location = New Point(xLocation, yLocation + 200)                       'Location of RTB
            }
            TabPage2.Controls.Add(LocEc(Index))                                         'Add RichTextBoxes to TabPage2
            xLocation += 210                                                            'adjust X location for next Image RTB location
            If (Index + 1) Mod 4 = 0 Then                                               'Adjust X and Y values for next instance
                xLocation = 10
                yLocation += 410
            End If
        Next
        reader.Close()
        xLocation = 10                                                                  'Reset X location
        yLocation = 10                                                                  'Reset Y location
        '----------------------Economy Class SQL----------------------------------------------------------------
        Dim Cmd2 As New SqlCommand($"SELECT * FROM Eco;", ConObj)
        reader = Cmd2.ExecuteReader

        If reader.HasRows = False Then
            reader.Close()
            Return
        End If
        While reader.Read
            Dim seat As Integer = Convert.ToInt32(reader.GetValue(0))
            Names(0) = reader.GetValue(1).ToString()
            Names(1) = reader.GetValue(2).ToString()
            Economy(seat).ImageLocation = FullSeatImg
            LocEc(seat).Text = $"{Names(0) & " " & Names(1)}"
        End While
        reader.Close()
        '--------------------------SQL Above Sql for Economy Class
    End Sub

    Private Sub PictureBoxClick(sender As Object, e As EventArgs)                       'Picturebox Click Event
        ClickedBox = sender                                                             'Instance of Clicked seat
        Names(0) = Fname.Text
        Names(1) = Lname.Text
        Dim Fn As String = Names(0) & " " & Names(1)                  'Short name for FName textbox
        Dim Hold As String = ClickedBox.Name.Substring(3)                                        'Get seat number
        SeatN.Text = Hold                                                               'Display Seat Number
        CurrentPassenger = Hold                                                        'Convert Seat Number to Integer
        Dim C = ClickedBox.Name.Substring(0, 3)
        DispBox.Text = ClickedBox.Name(1).ToString()                                       'Display Clicked Name


        If (C = "Biz") Then
            If (Fname.Text = "" Or Lname.Text = "") And LocBusiness(CurrentPassenger).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
            If ClickedBox.ImageLocation = EmptySeatImg Then
                ClickedBox.ImageLocation = FullSeatImg
                DispBox.Text = LocBusiness(CurrentPassenger).Text.ToString()                'Carbon copy the RTB on Display textbox
                LocBusiness(CurrentPassenger).Text = CurrentPassenger.ToString() & " " & Fn 'Displays Seat Number & Name
                Business(CurrentPassenger).ImageLocation = myImageLocationPrefix + FullSeatImg  'Update seat Image to FullseatImg
                Business(CurrentPassenger).Name = CurrentPassenger & " " & Fn                   'Update Array with Seat Number & Name
                Dim quearyString As String = $"INSERT INTO Bus(seat,Fname,Lname)VALUES({CurrentPassenger},'{Fname.Text}','{Lname.Text}')"
                Dim Cmd As New SqlCommand(quearyString, ConObj)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Record Added")
                Fname.Clear()
                Lname.Clear()
            End If
        ElseIf (C = "Eco") Then
            If (Fname.Text = "" Or Lname.Text = "") And LocEc(CurrentPassenger).Text = "" Then
                MessageBox.Show($"Please fill in {Names(0)} and {Names(1)}")
                Return
            End If
            If ClickedBox.ImageLocation = EmptySeatImg Then
                ClickedBox.ImageLocation = FullSeatImg
                LocEc(CurrentPassenger).Text = CurrentPassenger.ToString() & " " & Fn   'Display Seat Number & Name
                Economy(CurrentPassenger).ImageLocation = myImageLocationPrefix + FullSeatImg   'Change Seat image to FullSeatImg
                Economy(CurrentPassenger).Name = CurrentPassenger & " " & Fn                    'Adding Seat Number & Name to Economy Array
                Dim quearyString As String = $"INSERT INTO Eco(seat,Fname,Lname)VALUES({CurrentPassenger},'{Fname.Text}','{Lname.Text}')"
                Dim Cmd As New SqlCommand(quearyString, ConObj)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Record Added")
                Fname.Clear()
                Lname.Clear()
                Return
            End If
        End If
        If (ClickedBox.ImageLocation = FullSeatImg) Then
            Dim cancelOrNot As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Yes/No", MessageBoxButtons.YesNo)
            If cancelOrNot = 6 Then
                If (C = "Biz") Then
                    Dim Command As New SqlCommand($"DELETE FROM Bus Where seat = '{CurrentPassenger}';", ConObj)
                    Command.ExecuteNonQuery()
                    Business(CurrentPassenger).ImageLocation = myImageLocationPrefix + EmptySeatImg
                    LocBusiness(CurrentPassenger).Text = ""
                    Fname.Clear()
                    Lname.Clear()
                    MessageBox.Show("Record Delete Successful!!")
                ElseIf C = "Eco" Then
                    Dim Command As New SqlCommand($"DELETE FROM Eco Where seat = '{CurrentPassenger}';", ConObj)
                    Command.ExecuteNonQuery()
                    Economy(CurrentPassenger).ImageLocation = myImageLocationPrefix + EmptySeatImg
                    LocEc(CurrentPassenger).Text = ""
                    Fname.Clear()
                    Lname.Clear()
                    MessageBox.Show("Record Delete Successful!!")
                End If
            End If
        End If

    End Sub



End Class
