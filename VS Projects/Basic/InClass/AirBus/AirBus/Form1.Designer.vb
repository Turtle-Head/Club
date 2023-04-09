<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Fname = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Lname = New TextBox()
        SeatN = New TextBox()
        DispBox = New RichTextBox()
        TabPage1 = New TabPage()
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Fname
        ' 
        Fname.Location = New Point(13, 13)
        Fname.Name = "Fname"
        Fname.PlaceholderText = "First Name"
        Fname.Size = New Size(100, 23)
        Fname.TabIndex = 0
        Fname.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumBlue
        Label1.Font = New Font("Viner Hand ITC", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(30, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 103)
        Label1.TabIndex = 3
        Label1.Text = "AirBus"' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Lname)
        Panel1.Controls.Add(SeatN)
        Panel1.Controls.Add(DispBox)
        Panel1.Controls.Add(Fname)
        Panel1.Location = New Point(12, 173)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(127, 281)
        Panel1.TabIndex = 4
        ' 
        ' Lname
        ' 
        Lname.Location = New Point(13, 42)
        Lname.Name = "Lname"
        Lname.PlaceholderText = "Last Name"
        Lname.Size = New Size(100, 23)
        Lname.TabIndex = 1
        Lname.TextAlign = HorizontalAlignment.Center
        ' 
        ' SeatN
        ' 
        SeatN.BackColor = SystemColors.InfoText
        SeatN.ForeColor = Color.Lime
        SeatN.Location = New Point(13, 71)
        SeatN.Name = "SeatN"
        SeatN.PlaceholderText = "Seat"
        SeatN.Size = New Size(100, 23)
        SeatN.TabIndex = 4
        SeatN.TabStop = False
        SeatN.TextAlign = HorizontalAlignment.Center
        ' 
        ' DispBox
        ' 
        DispBox.BackColor = SystemColors.InfoText
        DispBox.ForeColor = Color.Lime
        DispBox.Location = New Point(16, 116)
        DispBox.Name = "DispBox"
        DispBox.Size = New Size(97, 145)
        DispBox.TabIndex = 2
        DispBox.TabStop = False
        DispBox.Text = ""' 
        ' TabPage1
        ' 
        TabPage1.AutoScroll = True
        TabPage1.BackColor = Color.Transparent
        TabPage1.Cursor = Cursors.Hand
        TabPage1.Font = New Font("Palatino Linotype", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TabPage1.ForeColor = SystemColors.ActiveCaptionText
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(873, 286)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Business"' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(163, 149)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(881, 314)
        TabControl1.TabIndex = 5
        ' 
        ' TabPage2
        ' 
        TabPage2.AutoScroll = True
        TabPage2.BackColor = Color.Transparent
        TabPage2.Cursor = Cursors.Hand
        TabPage2.Font = New Font("Palatino Linotype", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TabPage2.ForeColor = SystemColors.ActiveCaptionText
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(873, 286)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Economy"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.vector_2483061_960_720
        ClientSize = New Size(1070, 487)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "AirBus Seats"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DispBox As RichTextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SeatN As TextBox
    Friend WithEvents Lname As TextBox
End Class
