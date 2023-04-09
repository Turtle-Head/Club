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
        GrabMe = New TextBox()
        ClrButton = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(38, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 23)
        Button1.TabIndex = 0
        Button1.Text = "PushMe"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Output
        ' 
        Output.Location = New Point(38, 68)
        Output.Name = "Output"
        Output.Size = New Size(204, 96)
        Output.TabIndex = 1
        Output.Text = ""' 
        ' GrabMe
        ' 
        GrabMe.Location = New Point(38, 182)
        GrabMe.Name = "GrabMe"
        GrabMe.PlaceholderText = "phrase"
        GrabMe.Size = New Size(204, 23)
        GrabMe.TabIndex = 2
        GrabMe.TextAlign = HorizontalAlignment.Center
        ' 
        ' ClrButton
        ' 
        ClrButton.Location = New Point(40, 217)
        ClrButton.Name = "ClrButton"
        ClrButton.Size = New Size(202, 23)
        ClrButton.TabIndex = 3
        ClrButton.Text = "Clear"
        ClrButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(293, 373)
        Controls.Add(ClrButton)
        Controls.Add(GrabMe)
        Controls.Add(Output)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Output As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GrabMe As TextBox
    Friend WithEvents ClrButton As Button
End Class
