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
        b1 = New Button()
        GB1 = New GroupBox()
        output = New RichTextBox()
        GB1.SuspendLayout()
        SuspendLayout()
        ' 
        ' b1
        ' 
        b1.Font = New Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        b1.Location = New Point(23, 22)
        b1.Name = "b1"
        b1.Size = New Size(265, 47)
        b1.TabIndex = 0
        b1.Text = "Activate"
        b1.UseVisualStyleBackColor = True
        ' 
        ' GB1
        ' 
        GB1.Controls.Add(output)
        GB1.Controls.Add(b1)
        GB1.Location = New Point(31, 24)
        GB1.Name = "GB1"
        GB1.Size = New Size(315, 161)
        GB1.TabIndex = 1
        GB1.TabStop = False
        GB1.Text = "Bubble"
        ' 
        ' output
        ' 
        output.Font = New Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        output.Location = New Point(23, 75)
        output.Name = "output"
        output.Size = New Size(265, 64)
        output.TabIndex = 1
        output.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 226)
        Controls.Add(GB1)
        Name = "Form1"
        Text = "Form1"
        GB1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents b1 As Button
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents output As RichTextBox
End Class
