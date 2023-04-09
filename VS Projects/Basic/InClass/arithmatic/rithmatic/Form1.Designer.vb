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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        ClkMe = New Button()
        Output = New RichTextBox()
        Num1 = New TextBox()
        Num2 = New TextBox()
        Op = New TextBox()
        ClrB = New Button()
        SuspendLayout()
        ' 
        ' ClkMe
        ' 
        ClkMe.BackgroundImage = CType(resources.GetObject("ClkMe.BackgroundImage"), Image)
        ClkMe.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ClkMe.ForeColor = Color.DeepSkyBlue
        ClkMe.Location = New Point(12, 12)
        ClkMe.Name = "ClkMe"
        ClkMe.Size = New Size(222, 42)
        ClkMe.TabIndex = 0
        ClkMe.Text = "Click Me"
        ClkMe.UseVisualStyleBackColor = True
        ' 
        ' Output
        ' 
        Output.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Output.Location = New Point(355, 12)
        Output.Name = "Output"
        Output.Size = New Size(219, 81)
        Output.TabIndex = 5
        Output.TabStop = False
        Output.Text = ""
        Output.WordWrap = False
        ' 
        ' Num1
        ' 
        Num1.Location = New Point(240, 12)
        Num1.Name = "Num1"
        Num1.PlaceholderText = "Number 1"
        Num1.Size = New Size(100, 23)
        Num1.TabIndex = 1
        Num1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Num2
        ' 
        Num2.Location = New Point(240, 70)
        Num2.Name = "Num2"
        Num2.PlaceholderText = "Number 2"
        Num2.Size = New Size(100, 23)
        Num2.TabIndex = 2
        Num2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Op
        ' 
        Op.Location = New Point(240, 41)
        Op.Name = "Op"
        Op.PlaceholderText = "Operator"
        Op.RightToLeft = RightToLeft.No
        Op.Size = New Size(100, 23)
        Op.TabIndex = 3
        Op.TextAlign = HorizontalAlignment.Center
        ' 
        ' ClrB
        ' 
        ClrB.BackColor = Color.Red
        ClrB.Font = New Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ClrB.ForeColor = Color.DeepSkyBlue
        ClrB.Location = New Point(12, 62)
        ClrB.Name = "ClrB"
        ClrB.Size = New Size(222, 33)
        ClrB.TabIndex = 4
        ClrB.Text = "Clear"
        ClrB.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.square_2696914_960_720
        ClientSize = New Size(586, 121)
        Controls.Add(ClrB)
        Controls.Add(Op)
        Controls.Add(Num2)
        Controls.Add(Num1)
        Controls.Add(Output)
        Controls.Add(ClkMe)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Arithmatic"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ClkMe As Button
    Friend WithEvents Output As RichTextBox
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Op As TextBox
    Friend WithEvents ClrB As Button
End Class
