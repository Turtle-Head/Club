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
        TB = New RichTextBox()
        Dbut = New Button()
        SuspendLayout()
        ' 
        ' TB
        ' 
        TB.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TB.Location = New Point(43, 46)
        TB.Name = "TB"
        TB.Size = New Size(228, 96)
        TB.TabIndex = 0
        TB.Text = ""' 
        ' Dbut
        ' 
        Dbut.Location = New Point(42, 148)
        Dbut.Name = "Dbut"
        Dbut.Size = New Size(229, 38)
        Dbut.TabIndex = 1
        Dbut.Text = "Click"
        Dbut.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(305, 213)
        Controls.Add(Dbut)
        Controls.Add(TB)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TB As RichTextBox
    Friend WithEvents Dbut As Button
End Class
