namespace ExS31
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
            num1 = new TextBox();
            num2 = new TextBox();
            s1 = new Button();
            multp = new Button();
            divi = new Button();
            suts = new Button();
            CB = new Button();
            SuspendLayout();
            // 
            // output
            // 
            output.Font = new Font("OpenSymbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            output.Location = new Point(35, 35);
            output.Name = "output";
            output.Size = new Size(312, 96);
            output.TabIndex = 6;
            output.TabStop = false;
            output.Text = "";
            // 
            // num1
            // 
            num1.Location = new Point(35, 143);
            num1.Name = "num1";
            num1.PlaceholderText = "Number 1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 0;
            num1.TextAlign = HorizontalAlignment.Center;
            // 
            // num2
            // 
            num2.Location = new Point(35, 181);
            num2.Name = "num2";
            num2.PlaceholderText = "Number 2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 1;
            num2.TextAlign = HorizontalAlignment.Center;
            // 
            // s1
            // 
            s1.Location = new Point(247, 137);
            s1.Name = "s1";
            s1.Size = new Size(100, 33);
            s1.TabIndex = 2;
            s1.Text = "Sum";
            s1.UseVisualStyleBackColor = true;
            s1.Click += s1_Click;
            // 
            // multp
            // 
            multp.Location = new Point(141, 137);
            multp.Name = "multp";
            multp.Size = new Size(100, 31);
            multp.TabIndex = 4;
            multp.Text = "Product";
            multp.UseVisualStyleBackColor = true;
            multp.Click += multp_Click;
            // 
            // divi
            // 
            divi.Location = new Point(141, 176);
            divi.Name = "divi";
            divi.Size = new Size(100, 31);
            divi.TabIndex = 5;
            divi.Text = "Quotient";
            divi.UseVisualStyleBackColor = true;
            divi.Click += divi_Click;
            // 
            // suts
            // 
            suts.Location = new Point(247, 176);
            suts.Name = "suts";
            suts.Size = new Size(100, 31);
            suts.TabIndex = 3;
            suts.Text = "Subtract";
            suts.UseVisualStyleBackColor = true;
            suts.Click += suts_Click;
            // 
            // CB
            // 
            CB.BackColor = Color.Red;
            CB.ForeColor = SystemColors.HighlightText;
            CB.Location = new Point(27, 6);
            CB.Name = "CB";
            CB.Size = new Size(75, 23);
            CB.TabIndex = 7;
            CB.Text = "AC";
            CB.UseVisualStyleBackColor = false;
            CB.Click += CB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 231);
            Controls.Add(CB);
            Controls.Add(suts);
            Controls.Add(divi);
            Controls.Add(multp);
            Controls.Add(s1);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox output;
        private TextBox num1;
        private TextBox num2;
        private Button s1;
        private Button multp;
        private Button divi;
        private Button suts;
        private Button CB;
    }
}