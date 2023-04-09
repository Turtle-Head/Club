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
        Rondo = New Button()
        Output = New RichTextBox()
        SuspendLayout()
        ' 
        ' Rondo
        ' 
        Rondo.Location = New Point(12, 12)
        Rondo.Name = "Rondo"
        Rondo.Size = New Size(263, 34)
        Rondo.TabIndex = 0
        Rondo.Text = "Exercise 1"
        Rondo.UseVisualStyleBackColor = True
        ' 
        ' Output
        ' 
        Output.Location = New Point(12, 52)
        Output.Name = "Output"
        Output.Size = New Size(263, 96)
        Output.TabIndex = 1
        Output.Text = ""' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(295, 165)
        Controls.Add(Output)
        Controls.Add(Rondo)
        Name = "Form1"
        Text = "Exercise 1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Rondo As Button
    Friend WithEvents Output As RichTextBox
End Class
