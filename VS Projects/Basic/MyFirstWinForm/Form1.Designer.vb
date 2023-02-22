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
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Number1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        StatusStrip1 = New StatusStrip()
        MenuStrip1 = New MenuStrip()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(373, 73)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 99)
        Button1.TabIndex = 0
        Button1.Text = "Sum"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(258, 73)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(62, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(258, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(62, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(258, 137)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(62, 23)
        TextBox3.TabIndex = 3
        ' 
        ' Number1
        ' 
        Number1.AutoSize = True
        Number1.Location = New Point(192, 76)
        Number1.Name = "Number1"
        Number1.Size = New Size(60, 15)
        Number1.TabIndex = 4
        Number1.Text = "Number 1"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 5
        Label2.Text = "Number 2"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(205, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 6
        Label3.Text = "Result"' 
        ' StatusStrip1
        ' 
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 7
        StatusStrip1.Text = "StatusStrip1"' 
        ' MenuStrip1
        ' 
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"' 
        ' Button2
        ' 
        Button2.Location = New Point(486, 77)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Subtract"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(488, 114)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 10
        Button3.Text = "Multiply"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(492, 149)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 11
        Button4.Text = "Divide"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Number1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Number1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
