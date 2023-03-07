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
        Num = New TextBox()
        OptBox = New RichTextBox()
        ActNow = New Button()
        ClrB = New Button()
        SuspendLayout()
        ' 
        ' Num
        ' 
        Num.AcceptsTab = True
        Num.Location = New Point(42, 40)
        Num.Name = "Num"
        Num.PlaceholderText = "enter a Number"
        Num.Size = New Size(236, 23)
        Num.TabIndex = 0
        Num.TextAlign = HorizontalAlignment.Center
        ' 
        ' OptBox
        ' 
        OptBox.Location = New Point(40, 91)
        OptBox.Name = "OptBox"
        OptBox.ReadOnly = True
        OptBox.ScrollBars = RichTextBoxScrollBars.Vertical
        OptBox.Size = New Size(238, 225)
        OptBox.TabIndex = 2
        OptBox.TabStop = False
        OptBox.Text = ""' 
        ' ActNow
        ' 
        ActNow.BackColor = Color.DodgerBlue
        ActNow.ForeColor = Color.Gold
        ActNow.Location = New Point(42, 334)
        ActNow.Name = "ActNow"
        ActNow.Size = New Size(115, 37)
        ActNow.TabIndex = 1
        ActNow.Text = "Randomize"
        ActNow.UseVisualStyleBackColor = False
        ' 
        ' ClrB
        ' 
        ClrB.BackColor = Color.Red
        ClrB.ForeColor = Color.Gold
        ClrB.Location = New Point(163, 337)
        ClrB.Name = "ClrB"
        ClrB.Size = New Size(115, 34)
        ClrB.TabIndex = 3
        ClrB.Text = "Reset"
        ClrB.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(303, 388)
        Controls.Add(ClrB)
        Controls.Add(ActNow)
        Controls.Add(OptBox)
        Controls.Add(Num)
        Name = "Form1"
        Text = "Randy"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Num As TextBox
    Friend WithEvents OptBox As RichTextBox
    Friend WithEvents ActNow As Button
    Friend WithEvents ClrB As Button
End Class
