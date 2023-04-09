namespace EvenOddCs
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
            b1 = new Button();
            ck = new TextBox();
            output = new TextBox();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(169, 33);
            b1.Name = "b1";
            b1.Size = new Size(101, 23);
            b1.TabIndex = 0;
            b1.Text = "Check";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // ck
            // 
            ck.Location = new Point(35, 33);
            ck.Name = "ck";
            ck.PlaceholderText = "Number";
            ck.Size = new Size(100, 23);
            ck.TabIndex = 1;
            ck.TextAlign = HorizontalAlignment.Center;
            // 
            // output
            // 
            output.Location = new Point(35, 73);
            output.Name = "output";
            output.PlaceholderText = "Output";
            output.Size = new Size(235, 23);
            output.TabIndex = 2;
            output.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 236);
            Controls.Add(output);
            Controls.Add(ck);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private TextBox ck;
        private TextBox output;
    }
}