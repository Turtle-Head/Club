namespace _29ICEx
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
            panel1 = new Panel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            output = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(output);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 184);
            panel1.TabIndex = 0;
            // 
            // b1
            // 
            b1.Location = new Point(12, 212);
            b1.Name = "b1";
            b1.Size = new Size(94, 41);
            b1.TabIndex = 1;
            b1.Text = "Start";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(112, 212);
            b2.Name = "b2";
            b2.Size = new Size(94, 41);
            b2.TabIndex = 2;
            b2.Text = "Next";
            b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Location = new Point(212, 212);
            b3.Name = "b3";
            b3.Size = new Size(94, 41);
            b3.TabIndex = 3;
            b3.Text = "Continue";
            b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            b4.Location = new Point(316, 212);
            b4.Name = "b4";
            b4.Size = new Size(94, 41);
            b4.TabIndex = 4;
            b4.Text = "End";
            b4.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            output.BackColor = SystemColors.InactiveCaptionText;
            output.Font = new Font("Rubik", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            output.ForeColor = Color.Lime;
            output.Location = new Point(3, 3);
            output.Name = "output";
            output.Size = new Size(392, 178);
            output.TabIndex = 0;
            output.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.square_2696914_960_720;
            ClientSize = new Size(422, 351);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox output;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
    }
}