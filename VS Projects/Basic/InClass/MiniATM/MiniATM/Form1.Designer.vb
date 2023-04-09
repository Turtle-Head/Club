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
        BalCheck = New Button()
        Amount = New TextBox()
        Output = New RichTextBox()
        Balance = New TextBox()
        Withdraw = New Button()
        Depo = New Button()
        Clr = New Button()
        SuspendLayout()
        ' 
        ' BalCheck
        ' 
        BalCheck.BackColor = Color.Chartreuse
        BalCheck.Location = New Point(40, 12)
        BalCheck.Name = "BalCheck"
        BalCheck.Size = New Size(161, 23)
        BalCheck.TabIndex = 0
        BalCheck.Text = "Balance"
        BalCheck.UseVisualStyleBackColor = False
        ' 
        ' Amount
        ' 
        Amount.BackColor = Color.Khaki
        Amount.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Amount.Location = New Point(207, 38)
        Amount.Name = "Amount"
        Amount.PlaceholderText = "Amount"
        Amount.Size = New Size(204, 27)
        Amount.TabIndex = 1
        Amount.TextAlign = HorizontalAlignment.Center
        ' 
        ' Output
        ' 
        Output.BackColor = Color.Black
        Output.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Output.ForeColor = Color.GreenYellow
        Output.Location = New Point(12, 71)
        Output.Name = "Output"
        Output.ReadOnly = True
        Output.Size = New Size(399, 347)
        Output.TabIndex = 2
        Output.Text = ""' 
        ' Balance
        ' 
        Balance.BackColor = Color.Lime
        Balance.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Balance.Location = New Point(12, 38)
        Balance.Name = "Balance"
        Balance.PlaceholderText = "Balance"
        Balance.Size = New Size(189, 27)
        Balance.TabIndex = 3
        Balance.TextAlign = HorizontalAlignment.Center
        ' 
        ' Withdraw
        ' 
        Withdraw.BackColor = Color.Red
        Withdraw.Location = New Point(207, 12)
        Withdraw.Name = "Withdraw"
        Withdraw.Size = New Size(94, 23)
        Withdraw.TabIndex = 4
        Withdraw.Text = "Withdraw"
        Withdraw.UseVisualStyleBackColor = False
        ' 
        ' Depo
        ' 
        Depo.BackColor = Color.DeepSkyBlue
        Depo.Location = New Point(307, 12)
        Depo.Name = "Depo"
        Depo.Size = New Size(104, 23)
        Depo.TabIndex = 5
        Depo.Text = "Deposit"
        Depo.UseVisualStyleBackColor = False
        ' 
        ' Clr
        ' 
        Clr.BackColor = Color.Red
        Clr.Location = New Point(12, 12)
        Clr.Name = "Clr"
        Clr.Size = New Size(22, 23)
        Clr.TabIndex = 6
        Clr.Text = "C"
        Clr.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.circle_2696910_960_720
        ClientSize = New Size(423, 438)
        Controls.Add(Clr)
        Controls.Add(Depo)
        Controls.Add(Withdraw)
        Controls.Add(Balance)
        Controls.Add(Output)
        Controls.Add(Amount)
        Controls.Add(BalCheck)
        Name = "Form1"
        Text = "Mini ATM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BalCheck As Button
    Friend WithEvents Amount As TextBox
    Friend WithEvents Output As RichTextBox
    Friend WithEvents Balance As TextBox
    Friend WithEvents Withdraw As Button
    Friend WithEvents Depo As Button
    Friend WithEvents Clr As Button
End Class
