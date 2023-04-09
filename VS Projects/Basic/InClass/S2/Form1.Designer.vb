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
        Output = New RichTextBox()
        Num1 = New TextBox()
        Num2 = New TextBox()
        CBut = New Button()
        Mutten = New Button()
        DVb = New Button()
        Minty = New Button()
        Mtab = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(15, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 40)
        Button1.TabIndex = 0
        Button1.Text = "Sum"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Output
        ' 
        Output.Location = New Point(143, 16)
        Output.Name = "Output"
        Output.ScrollBars = RichTextBoxScrollBars.Vertical
        Output.Size = New Size(100, 75)
        Output.TabIndex = 1
        Output.Text = ""' 
        ' Num1
        ' 
        Num1.Location = New Point(16, 99)
        Num1.Name = "Num1"
        Num1.PlaceholderText = "Number 1"
        Num1.RightToLeft = RightToLeft.No
        Num1.Size = New Size(100, 23)
        Num1.TabIndex = 2
        Num1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(143, 99)
        Num2.Name = "Num2"
        Num2.PlaceholderText = "Number 2"
        Num2.Size = New Size(100, 23)
        Num2.TabIndex = 3
        Num2.TextAlign = HorizontalAlignment.Center
        ' 
        ' CBut
        ' 
        CBut.BackColor = Color.Red
        CBut.ForeColor = SystemColors.Info
        CBut.Location = New Point(249, 98)
        CBut.Name = "CBut"
        CBut.Size = New Size(34, 23)
        CBut.TabIndex = 4
        CBut.Text = "Clr"
        CBut.UseVisualStyleBackColor = False
        ' 
        ' Mutten
        ' 
        Mutten.BackColor = Color.DodgerBlue
        Mutten.ForeColor = SystemColors.Info
        Mutten.Location = New Point(249, 16)
        Mutten.Name = "Mutten"
        Mutten.Size = New Size(34, 23)
        Mutten.TabIndex = 5
        Mutten.Text = "*"
        Mutten.UseVisualStyleBackColor = False
        ' 
        ' DVb
        ' 
        DVb.BackColor = Color.DodgerBlue
        DVb.ForeColor = SystemColors.Info
        DVb.Location = New Point(249, 45)
        DVb.Name = "DVb"
        DVb.Size = New Size(34, 23)
        DVb.TabIndex = 6
        DVb.Text = "/"
        DVb.UseVisualStyleBackColor = False
        ' 
        ' Minty
        ' 
        Minty.BackColor = Color.DodgerBlue
        Minty.ForeColor = SystemColors.Info
        Minty.Location = New Point(249, 74)
        Minty.Name = "Minty"
        Minty.Size = New Size(34, 23)
        Minty.TabIndex = 7
        Minty.Text = "-"
        Minty.UseVisualStyleBackColor = False
        ' 
        ' Mtab
        ' 
        Mtab.BackColor = Color.DodgerBlue
        Mtab.ForeColor = SystemColors.Info
        Mtab.Location = New Point(16, 62)
        Mtab.Name = "Mtab"
        Mtab.Size = New Size(92, 29)
        Mtab.TabIndex = 8
        Mtab.Text = "Multi-Table"
        Mtab.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.blue_2889388_960_720
        ClientSize = New Size(319, 142)
        Controls.Add(Mtab)
        Controls.Add(Minty)
        Controls.Add(DVb)
        Controls.Add(Mutten)
        Controls.Add(CBut)
        Controls.Add(Num2)
        Controls.Add(Num1)
        Controls.Add(Output)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "S2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Output As RichTextBox
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents CBut As Button
    Friend WithEvents Mutten As Button
    Friend WithEvents DVb As Button
    Friend WithEvents Minty As Button
    Friend WithEvents Mtab As Button
End Class
