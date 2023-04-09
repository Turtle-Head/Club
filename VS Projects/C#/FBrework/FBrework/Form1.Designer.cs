namespace FBrework
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
            num = new TextBox();
            output = new TextBox();
            b1 = new Button();
            SuspendLayout();
            // 
            // num
            // 
            num.Location = new Point(60, 30);
            num.Name = "num";
            num.Size = new Size(76, 23);
            num.TabIndex = 0;
            // 
            // output
            // 
            output.Location = new Point(60, 65);
            output.Name = "output";
            output.Size = new Size(174, 23);
            output.TabIndex = 1;
            // 
            // b1
            // 
            b1.Location = new Point(157, 32);
            b1.Name = "b1";
            b1.Size = new Size(75, 23);
            b1.TabIndex = 2;
            b1.Text = "Check";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 127);
            Controls.Add(b1);
            Controls.Add(output);
            Controls.Add(num);
            Name = "Form1";
            Text = "FizzBuzz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num;
        private TextBox output;
        private Button b1;
    }
}