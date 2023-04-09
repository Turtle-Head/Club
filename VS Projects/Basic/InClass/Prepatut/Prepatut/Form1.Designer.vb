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
        Out = New RichTextBox()
        CM = New Button()
        SuspendLayout()
        ' 
        ' Out
        ' 
        Out.BackColor = SystemColors.MenuText
        Out.ForeColor = Color.LimeGreen
        Out.Location = New Point(12, 12)
        Out.Name = "Out"
        Out.Size = New Size(266, 145)
        Out.TabIndex = 0
        Out.Text = ""' 
        ' CM
        ' 
        CM.BackColor = Color.RoyalBlue
        CM.ForeColor = SystemColors.Info
        CM.Location = New Point(13, 170)
        CM.Name = "CM"
        CM.Size = New Size(265, 35)
        CM.TabIndex = 1
        CM.Text = "ClickMe"
        CM.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(305, 224)
        Controls.Add(CM)
        Controls.Add(Out)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Out As RichTextBox
    Friend WithEvents CM As Button
End Class
