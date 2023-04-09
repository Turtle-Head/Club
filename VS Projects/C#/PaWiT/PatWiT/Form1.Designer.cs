namespace PatWiT
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
            fact = new Button();
            num1 = new TextBox();
            Power = new Button();
            num2 = new TextBox();
            num3 = new TextBox();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(12, 93);
            output.Name = "output";
            output.Size = new Size(290, 133);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // fact
            // 
            fact.Location = new Point(146, 38);
            fact.Name = "fact";
            fact.Size = new Size(155, 38);
            fact.TabIndex = 1;
            fact.Text = "Factorial";
            fact.UseVisualStyleBackColor = true;
            fact.Click += fact_Click;
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            num1.Location = new Point(26, 38);
            num1.Name = "num1";
            num1.PlaceholderText = "Factorial";
            num1.Size = new Size(100, 35);
            num1.TabIndex = 2;
            num1.TextAlign = HorizontalAlignment.Center;
            // 
            // Power
            // 
            Power.Location = new Point(146, 245);
            Power.Name = "Power";
            Power.Size = new Size(151, 58);
            Power.TabIndex = 3;
            Power.Text = "Power";
            Power.UseVisualStyleBackColor = true;
            Power.Click += Power_Click;
            // 
            // num2
            // 
            num2.Location = new Point(26, 246);
            num2.Name = "num2";
            num2.PlaceholderText = "Number";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 4;
            num2.TextAlign = HorizontalAlignment.Center;
            // 
            // num3
            // 
            num3.Location = new Point(25, 280);
            num3.Name = "num3";
            num3.PlaceholderText = "Power";
            num3.Size = new Size(100, 23);
            num3.TabIndex = 5;
            num3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 450);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(Power);
            Controls.Add(num1);
            Controls.Add(fact);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox output;
        private Button fact;
        private TextBox num1;
        private Button Power;
        private TextBox num2;
        private TextBox num3;
    }
}