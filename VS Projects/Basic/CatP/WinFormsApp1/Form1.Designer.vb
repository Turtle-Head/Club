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
        theMessage = New RichTextBox()
        Result = New RichTextBox()
        cct = New Button()
        Pname = New TextBox()
        clr = New Button()
        SuspendLayout()
        ' 
        ' theMessage
        ' 
        theMessage.BackColor = Color.LightCyan
        theMessage.Location = New Point(12, 65)
        theMessage.Name = "theMessage"
        theMessage.Size = New Size(251, 65)
        theMessage.TabIndex = 2
        theMessage.Text = "" ' 
        ' Result
        ' 
        Result.BackColor = Color.GreenYellow
        Result.Location = New Point(12, 205)
        Result.Name = "Result"
        Result.Size = New Size(251, 103)
        Result.TabIndex = 4
        Result.Text = "" ' 
        ' cct
        ' 
        cct.BackColor = Color.LawnGreen
        cct.Location = New Point(12, 136)
        cct.Name = "cct"
        cct.Size = New Size(251, 63)
        cct.TabIndex = 3
        cct.Text = "Concat"
        cct.UseVisualStyleBackColor = False
        ' 
        ' Pname
        ' 
        Pname.BackColor = Color.LightCyan
        Pname.Location = New Point(14, 26)
        Pname.Name = "Pname"
        Pname.Size = New Size(251, 23)
        Pname.TabIndex = 1
        Pname.Text = "Merlin the Magnificient" ' 
        ' clr
        ' 
        clr.BackColor = Color.DodgerBlue
        clr.ForeColor = Color.Gold
        clr.Location = New Point(14, 314)
        clr.Name = "clr"
        clr.Size = New Size(251, 67)
        clr.TabIndex = 5
        clr.Text = "Clear"
        clr.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(277, 429)
        Controls.Add(clr)
        Controls.Add(Pname)
        Controls.Add(cct)
        Controls.Add(Result)
        Controls.Add(theMessage)
        Name = "Form1"
        Text = "GPLoader"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents theMessage As RichTextBox
    Friend WithEvents Result As RichTextBox
    Friend WithEvents cct As Button
    Friend WithEvents Pname As TextBox
    Friend WithEvents clr As Button
End Class
