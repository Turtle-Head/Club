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
        eotest = New Button()
        num1 = New TextBox()
        num2 = New TextBox()
        resbox = New TextBox()
        resbox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        fbval = New TextBox()
        fbres = New TextBox()
        FBcheck = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' eotest
        ' 
        eotest.Location = New Point(34, 86)
        eotest.Name = "eotest"
        eotest.Size = New Size(223, 35)
        eotest.TabIndex = 1
        eotest.Text = "Even Odd"
        eotest.UseVisualStyleBackColor = True
        ' 
        ' num1
        ' 
        num1.Location = New Point(34, 28)
        num1.Name = "num1"
        num1.Size = New Size(100, 23)
        num1.TabIndex = 2
        ' 
        ' num2
        ' 
        num2.Location = New Point(34, 57)
        num2.Name = "num2"
        num2.Size = New Size(100, 23)
        num2.TabIndex = 3
        ' 
        ' resbox
        ' 
        resbox.Location = New Point(157, 28)
        resbox.Name = "resbox"
        resbox.Size = New Size(100, 23)
        resbox.TabIndex = 4
        ' 
        ' resbox2
        ' 
        resbox2.Location = New Point(157, 57)
        resbox2.Name = "resbox2"
        resbox2.Size = New Size(100, 23)
        resbox2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 6
        Label1.Text = "Number"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 7
        Label2.Text = "Even or Odd "' 
        ' fbval
        ' 
        fbval.Location = New Point(38, 149)
        fbval.Name = "fbval"
        fbval.Size = New Size(100, 23)
        fbval.TabIndex = 8
        ' 
        ' fbres
        ' 
        fbres.Location = New Point(157, 149)
        fbres.Name = "fbres"
        fbres.Size = New Size(100, 23)
        fbres.TabIndex = 9
        ' 
        ' FBcheck
        ' 
        FBcheck.Location = New Point(38, 178)
        FBcheck.Name = "FBcheck"
        FBcheck.Size = New Size(219, 45)
        FBcheck.TabIndex = 10
        FBcheck.Text = "Check Quality"
        FBcheck.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(157, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 11
        Label3.Text = "Fizz Buzz Result"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 12
        Label4.Text = "Number"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 250)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(FBcheck)
        Controls.Add(fbres)
        Controls.Add(fbval)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(resbox2)
        Controls.Add(resbox)
        Controls.Add(num2)
        Controls.Add(num1)
        Controls.Add(eotest)
        Name = "Form1"
        Text = "IFPS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents eotest As Button
    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents resbox As TextBox
    Friend WithEvents resbox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fbval As TextBox
    Friend WithEvents fbres As TextBox
    Friend WithEvents FBcheck As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
