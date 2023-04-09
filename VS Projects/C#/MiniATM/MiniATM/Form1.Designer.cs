namespace MiniATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            output = new RichTextBox();
            atmLab = new Label();
            wd = new Button();
            num = new TextBox();
            balck = new Button();
            depos = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.BackColor = SystemColors.MenuText;
            output.ForeColor = Color.Lime;
            output.Location = new Point(25, 38);
            output.Name = "output";
            output.Size = new Size(104, 96);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // atmLab
            // 
            atmLab.AutoSize = true;
            atmLab.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            atmLab.Location = new Point(30, 8);
            atmLab.Name = "atmLab";
            atmLab.Size = new Size(99, 22);
            atmLab.TabIndex = 1;
            atmLab.Text = "MiniATM";
            // 
            // wd
            // 
            wd.Location = new Point(25, 169);
            wd.Name = "wd";
            wd.Size = new Size(104, 33);
            wd.TabIndex = 2;
            wd.Text = "Withdraw";
            wd.UseVisualStyleBackColor = true;
            wd.Click += wd_Click;
            // 
            // num
            // 
            num.Location = new Point(25, 141);
            num.Name = "num";
            num.PlaceholderText = "Amount";
            num.Size = new Size(104, 23);
            num.TabIndex = 0;
            num.TextAlign = HorizontalAlignment.Center;
            // 
            // balck
            // 
            balck.Location = new Point(25, 253);
            balck.Name = "balck";
            balck.Size = new Size(104, 34);
            balck.TabIndex = 4;
            balck.Text = "Ballance";
            balck.UseVisualStyleBackColor = true;
            balck.Click += balck_Click;
            // 
            // depos
            // 
            depos.Location = new Point(25, 208);
            depos.Name = "depos";
            depos.Size = new Size(104, 39);
            depos.TabIndex = 5;
            depos.Text = "Deposit";
            depos.UseVisualStyleBackColor = true;
            depos.Click += depos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(153, 299);
            Controls.Add(depos);
            Controls.Add(balck);
            Controls.Add(num);
            Controls.Add(wd);
            Controls.Add(atmLab);
            Controls.Add(output);
            Name = "Form1";
            Text = "MiniATM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox output;
        private Label atmLab;
        private Button wd;
        private TextBox num;
        private Button balck;
        private Button depos;
    }
}