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
        DisplayResult = New RichTextBox()
        BAction = New Button()
        Num1 = New TextBox()
        Num2 = New TextBox()
        ClResultR = New Button()
        ResetB = New Button()
        EVB = New Button()
        OddB = New Button()
        Pchk = New Button()
        SuspendLayout()
        ' 
        ' DisplayResult
        ' 
        DisplayResult.Location = New Point(37, 88)
        DisplayResult.Name = "DisplayResult"
        DisplayResult.ReadOnly = True
        DisplayResult.Size = New Size(221, 183)
        DisplayResult.TabIndex = 0
        DisplayResult.Text = "Please Enter 2 Numbers to begin"' 
        ' BAction
        ' 
        BAction.Location = New Point(37, 277)
        BAction.Name = "BAction"
        BAction.Size = New Size(100, 32)
        BAction.TabIndex = 1
        BAction.Text = "Sum All"
        BAction.UseVisualStyleBackColor = True
        ' 
        ' Num1
        ' 
        Num1.Location = New Point(37, 27)
        Num1.Name = "Num1"
        Num1.PlaceholderText = "Number 1"
        Num1.Size = New Size(100, 23)
        Num1.TabIndex = 2
        Num1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(158, 27)
        Num2.Name = "Num2"
        Num2.PlaceholderText = "Number 2"
        Num2.Size = New Size(100, 23)
        Num2.TabIndex = 3
        Num2.TextAlign = HorizontalAlignment.Center
        ' 
        ' ClResultR
        ' 
        ClResultR.Location = New Point(37, 59)
        ClResultR.Name = "ClResultR"
        ClResultR.Size = New Size(100, 23)
        ClResultR.TabIndex = 4
        ClResultR.Text = "Clear"
        ClResultR.UseVisualStyleBackColor = True
        ' 
        ' ResetB
        ' 
        ResetB.Location = New Point(158, 59)
        ResetB.Name = "ResetB"
        ResetB.Size = New Size(100, 23)
        ResetB.TabIndex = 5
        ResetB.Text = "Reset"
        ResetB.UseVisualStyleBackColor = True
        ' 
        ' EVB
        ' 
        EVB.Location = New Point(158, 277)
        EVB.Name = "EVB"
        EVB.Size = New Size(100, 32)
        EVB.TabIndex = 6
        EVB.Text = "Even"
        EVB.UseVisualStyleBackColor = True
        ' 
        ' OddB
        ' 
        OddB.Location = New Point(158, 315)
        OddB.Name = "OddB"
        OddB.Size = New Size(100, 33)
        OddB.TabIndex = 7
        OddB.Text = "Odd"
        OddB.UseVisualStyleBackColor = True
        ' 
        ' Pchk
        ' 
        Pchk.Location = New Point(37, 315)
        Pchk.Name = "Pchk"
        Pchk.Size = New Size(100, 33)
        Pchk.TabIndex = 8
        Pchk.Text = "Prime ?"
        Pchk.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(304, 360)
        Controls.Add(Pchk)
        Controls.Add(OddB)
        Controls.Add(EVB)
        Controls.Add(ResetB)
        Controls.Add(ClResultR)
        Controls.Add(Num2)
        Controls.Add(Num1)
        Controls.Add(BAction)
        Controls.Add(DisplayResult)
        Name = "Form1"
        Text = "Looper"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DisplayResult As RichTextBox
    Friend WithEvents BAction As Button
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents ClResultR As Button
    Friend WithEvents ResetB As Button
    Friend WithEvents EVB As Button
    Friend WithEvents OddB As Button
    Friend WithEvents Pchk As Button
End Class
