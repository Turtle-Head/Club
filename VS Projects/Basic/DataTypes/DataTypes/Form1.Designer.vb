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
        num1 = New TextBox()
        num3 = New TextBox()
        num2 = New TextBox()
        num4 = New TextBox()
        res2 = New TextBox()
        res1 = New TextBox()
        Bfirst = New Button()
        Bsecond = New Button()
        otp = New RichTextBox()
        spet = New Button()
        SuspendLayout()
        ' 
        ' num1
        ' 
        num1.Location = New Point(29, 39)
        num1.Name = "num1"
        num1.Size = New Size(100, 23)
        num1.TabIndex = 0
        ' 
        ' num3
        ' 
        num3.Location = New Point(186, 39)
        num3.Name = "num3"
        num3.Size = New Size(100, 23)
        num3.TabIndex = 1
        ' 
        ' num2
        ' 
        num2.Location = New Point(29, 75)
        num2.Name = "num2"
        num2.Size = New Size(100, 23)
        num2.TabIndex = 2
        ' 
        ' num4
        ' 
        num4.Location = New Point(186, 75)
        num4.Name = "num4"
        num4.Size = New Size(100, 23)
        num4.TabIndex = 3
        ' 
        ' res2
        ' 
        res2.Location = New Point(186, 155)
        res2.Name = "res2"
        res2.Size = New Size(100, 23)
        res2.TabIndex = 4
        ' 
        ' res1
        ' 
        res1.Location = New Point(30, 155)
        res1.Name = "res1"
        res1.Size = New Size(100, 23)
        res1.TabIndex = 5
        ' 
        ' Bfirst
        ' 
        Bfirst.Location = New Point(29, 114)
        Bfirst.Name = "Bfirst"
        Bfirst.Size = New Size(101, 23)
        Bfirst.TabIndex = 6
        Bfirst.Text = "Concat"
        Bfirst.UseVisualStyleBackColor = True
        ' 
        ' Bsecond
        ' 
        Bsecond.Location = New Point(186, 114)
        Bsecond.Name = "Bsecond"
        Bsecond.Size = New Size(98, 23)
        Bsecond.TabIndex = 7
        Bsecond.Text = "Add"
        Bsecond.UseVisualStyleBackColor = True
        ' 
        ' otp
        ' 
        otp.Location = New Point(29, 202)
        otp.Name = "otp"
        otp.Size = New Size(255, 54)
        otp.TabIndex = 8
        otp.Text = ""' 
        ' spet
        ' 
        spet.Location = New Point(29, 267)
        spet.Name = "spet"
        spet.Size = New Size(255, 23)
        spet.TabIndex = 9
        spet.Text = "Special"
        spet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(337, 323)
        Controls.Add(spet)
        Controls.Add(otp)
        Controls.Add(Bsecond)
        Controls.Add(Bfirst)
        Controls.Add(res1)
        Controls.Add(res2)
        Controls.Add(num4)
        Controls.Add(num2)
        Controls.Add(num3)
        Controls.Add(num1)
        Name = "Form1"
        Text = "DataTypes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents num3 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents num4 As TextBox
    Friend WithEvents res2 As TextBox
    Friend WithEvents res1 As TextBox
    Friend WithEvents Bfirst As Button
    Friend WithEvents Bsecond As Button
    Friend WithEvents otp As RichTextBox
    Friend WithEvents spet As Button
End Class
