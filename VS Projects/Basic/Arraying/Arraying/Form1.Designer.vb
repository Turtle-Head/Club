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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Total = New Button()
        Opt1 = New TextBox()
        NTot = New Button()
        Otp2 = New RichTextBox()
        Label1 = New Label()
        RNum = New Button()
        SuspendLayout()
        ' 
        ' Total
        ' 
        Total.BackColor = Color.GreenYellow
        Total.Location = New Point(73, 45)
        Total.Name = "Total"
        Total.Size = New Size(75, 23)
        Total.TabIndex = 0
        Total.Text = "Exercise 1"
        Total.UseVisualStyleBackColor = False
        ' 
        ' Opt1
        ' 
        Opt1.Location = New Point(154, 46)
        Opt1.Name = "Opt1"
        Opt1.PlaceholderText = "Output"
        Opt1.Size = New Size(100, 23)
        Opt1.TabIndex = 1
        Opt1.TextAlign = HorizontalAlignment.Center
        ' 
        ' NTot
        ' 
        NTot.BackColor = Color.Chartreuse
        NTot.Location = New Point(73, 75)
        NTot.Name = "NTot"
        NTot.Size = New Size(75, 23)
        NTot.TabIndex = 2
        NTot.Text = "Exercise 2"
        NTot.UseVisualStyleBackColor = False
        ' 
        ' Otp2
        ' 
        Otp2.Location = New Point(12, 114)
        Otp2.Name = "Otp2"
        Otp2.Size = New Size(325, 199)
        Otp2.TabIndex = 3
        Otp2.Text = ""' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(12, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 4
        Label1.Text = "Output"' 
        ' RNum
        ' 
        RNum.BackColor = Color.LimeGreen
        RNum.Location = New Point(154, 75)
        RNum.Name = "RNum"
        RNum.Size = New Size(100, 23)
        RNum.TabIndex = 5
        RNum.Text = "Exercise 3"
        RNum.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(349, 339)
        Controls.Add(RNum)
        Controls.Add(Label1)
        Controls.Add(Otp2)
        Controls.Add(NTot)
        Controls.Add(Opt1)
        Controls.Add(Total)
        Name = "Form1"
        Text = "Array Exercise"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Total As Button
    Friend WithEvents Opt1 As TextBox
    Friend WithEvents NTot As Button
    Friend WithEvents Otp2 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RNum As Button
End Class
