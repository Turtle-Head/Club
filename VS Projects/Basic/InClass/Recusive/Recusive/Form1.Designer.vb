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
        RTB1 = New RichTextBox()
        FButton = New Button()
        Fx = New TextBox()
        F2 = New Button()
        Clr = New Button()
        SuspendLayout()
        ' 
        ' RTB1
        ' 
        RTB1.BackColor = SystemColors.InfoText
        RTB1.ForeColor = Color.Lime
        RTB1.Location = New Point(41, 83)
        RTB1.Name = "RTB1"
        RTB1.Size = New Size(195, 91)
        RTB1.TabIndex = 0
        RTB1.TabStop = False
        RTB1.Text = ""' 
        ' FButton
        ' 
        FButton.BackColor = Color.Lime
        FButton.Location = New Point(41, 16)
        FButton.Name = "FButton"
        FButton.Size = New Size(68, 56)
        FButton.TabIndex = 1
        FButton.Text = "Factorial"
        FButton.UseVisualStyleBackColor = False
        ' 
        ' Fx
        ' 
        Fx.BackColor = SystemColors.InfoText
        Fx.ForeColor = Color.Lime
        Fx.Location = New Point(170, 45)
        Fx.Name = "Fx"
        Fx.PlaceholderText = "15"
        Fx.Size = New Size(66, 23)
        Fx.TabIndex = 2
        Fx.TextAlign = HorizontalAlignment.Center
        ' 
        ' F2
        ' 
        F2.BackColor = Color.Lime
        F2.Location = New Point(170, 16)
        F2.Name = "F2"
        F2.Size = New Size(66, 23)
        F2.TabIndex = 3
        F2.Text = "Fx"
        F2.UseVisualStyleBackColor = False
        ' 
        ' Clr
        ' 
        Clr.BackgroundImage = My.Resources.Resources.square_2696914_960_720
        Clr.ForeColor = SystemColors.Info
        Clr.Location = New Point(115, 16)
        Clr.Name = "Clr"
        Clr.Size = New Size(49, 56)
        Clr.TabIndex = 4
        Clr.Text = "C"
        Clr.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.blue_2889369_960_720
        ClientSize = New Size(275, 200)
        Controls.Add(Clr)
        Controls.Add(F2)
        Controls.Add(Fx)
        Controls.Add(FButton)
        Controls.Add(RTB1)
        Name = "Form1"
        Text = "Factorial"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RTB1 As RichTextBox
    Friend WithEvents FButton As Button
    Friend WithEvents Fx As TextBox
    Friend WithEvents F2 As Button
    Friend WithEvents Clr As Button
End Class
