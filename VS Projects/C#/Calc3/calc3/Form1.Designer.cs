namespace calc3
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
            CL = new Button();
            num1 = new TextBox();
            num2 = new TextBox();
            op = new TextBox();
            cks = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(26, 23);
            output.Name = "output";
            output.Size = new Size(100, 41);
            output.TabIndex = 9;
            output.TabStop = false;
            output.Text = "";
            // 
            // CL
            // 
            CL.Location = new Point(132, 18);
            CL.Name = "CL";
            CL.Size = new Size(45, 46);
            CL.TabIndex = 0;
            CL.Text = "-0000=";
            CL.UseVisualStyleBackColor = true;
            CL.Click += CL_Click;
            // 
            // num1
            // 
            num1.Location = new Point(26, 96);
            num1.Name = "num1";
            num1.PlaceholderText = "Number 1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 1;
            num1.TextAlign = HorizontalAlignment.Center;
            // 
            // num2
            // 
            num2.Location = new Point(26, 154);
            num2.Name = "num2";
            num2.PlaceholderText = "Number 2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 3;
            num2.TextAlign = HorizontalAlignment.Center;
            // 
            // op
            // 
            op.Location = new Point(26, 125);
            op.Name = "op";
            op.PlaceholderText = "Operator";
            op.Size = new Size(100, 23);
            op.TabIndex = 2;
            op.TextAlign = HorizontalAlignment.Center;
            // 
            // cks
            // 
            cks.Location = new Point(26, 67);
            cks.Name = "cks";
            cks.Size = new Size(100, 23);
            cks.TabIndex = 4;
            cks.Text = "Check";
            cks.UseVisualStyleBackColor = true;
            cks.Click += cks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 203);
            Controls.Add(cks);
            Controls.Add(op);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(CL);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox output;
        private Button CL;
        private TextBox num1;
        private TextBox num2;
        private TextBox op;
        private Button cks;
    }
}