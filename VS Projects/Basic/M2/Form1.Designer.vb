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
        Ex1 = New Button()
        Output1 = New RichTextBox()
        Ex2 = New Button()
        Ex3 = New Button()
        Fire = New Button()
        Xv = New TextBox()
        Yv = New TextBox()
        SuspendLayout()
        ' 
        ' Ex1
        ' 
        Ex1.Location = New Point(12, 12)
        Ex1.Name = "Ex1"
        Ex1.Size = New Size(84, 42)
        Ex1.TabIndex = 0
        Ex1.Text = "Exercise 1"
        Ex1.UseVisualStyleBackColor = True
        ' 
        ' Output1
        ' 
        Output1.BackColor = Color.Ivory
        Output1.ForeColor = Color.DarkGreen
        Output1.Location = New Point(12, 60)
        Output1.Name = "Output1"
        Output1.ReadOnly = True
        Output1.Size = New Size(173, 126)
        Output1.TabIndex = 1
        Output1.TabStop = False
        Output1.Text = ""' 
        ' Ex2
        ' 
        Ex2.Location = New Point(102, 12)
        Ex2.Name = "Ex2"
        Ex2.Size = New Size(83, 42)
        Ex2.TabIndex = 2
        Ex2.Text = "Exercise 2"
        Ex2.UseVisualStyleBackColor = True
        ' 
        ' Ex3
        ' 
        Ex3.Location = New Point(12, 192)
        Ex3.Name = "Ex3"
        Ex3.Size = New Size(173, 40)
        Ex3.TabIndex = 3
        Ex3.Text = "Exercise 3"
        Ex3.UseVisualStyleBackColor = True
        ' 
        ' Fire
        ' 
        Fire.Location = New Point(191, 60)
        Fire.Name = "Fire"
        Fire.Size = New Size(61, 42)
        Fire.TabIndex = 4
        Fire.Text = "Fire"
        Fire.UseVisualStyleBackColor = True
        ' 
        ' Xv
        ' 
        Xv.Location = New Point(191, 117)
        Xv.Name = "Xv"
        Xv.PlaceholderText = "X value"
        Xv.Size = New Size(61, 23)
        Xv.TabIndex = 5
        Xv.TextAlign = HorizontalAlignment.Center
        Xv.WordWrap = False
        ' 
        ' Yv
        ' 
        Yv.Location = New Point(191, 146)
        Yv.Name = "Yv"
        Yv.PlaceholderText = "Y value"
        Yv.Size = New Size(61, 23)
        Yv.TabIndex = 6
        Yv.TextAlign = HorizontalAlignment.Center
        Yv.WordWrap = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(264, 244)
        Controls.Add(Yv)
        Controls.Add(Xv)
        Controls.Add(Fire)
        Controls.Add(Ex3)
        Controls.Add(Ex2)
        Controls.Add(Output1)
        Controls.Add(Ex1)
        Name = "Form1"
        Text = "M2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ex1 As Button
    Friend WithEvents Output1 As RichTextBox
    Friend WithEvents Ex2 As Button
    Friend WithEvents Ex3 As Button
    Friend WithEvents Fire As Button
    Friend WithEvents Xv As TextBox
    Friend WithEvents Yv As TextBox
End Class
