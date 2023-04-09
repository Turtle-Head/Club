namespace _28ICWork
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
            panel1 = new Panel();
            b1 = new Button();
            b2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // output
            // 
            output.Location = new Point(13, 127);
            output.Name = "output";
            output.Size = new Size(167, 91);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(b2);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(output);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 231);
            panel1.TabIndex = 1;
            // 
            // b1
            // 
            b1.Location = new Point(13, 18);
            b1.Name = "b1";
            b1.Size = new Size(167, 51);
            b1.TabIndex = 1;
            b1.Text = "Activate";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(18, 75);
            b2.Name = "b2";
            b2.Size = new Size(162, 46);
            b2.TabIndex = 2;
            b2.Text = "Random";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 268);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "28tries";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox output;
        private Panel panel1;
        private Button b1;
        private Button b2;
    }
}