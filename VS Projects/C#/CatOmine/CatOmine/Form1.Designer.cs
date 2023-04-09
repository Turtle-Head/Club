namespace CatOmine
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
            cbut = new Button();
            b1 = new TextBox();
            b2 = new TextBox();
            output = new RichTextBox();
            swp = new Button();
            SuspendLayout();
            // 
            // cbut
            // 
            cbut.Location = new Point(42, 96);
            cbut.Name = "cbut";
            cbut.Size = new Size(165, 62);
            cbut.TabIndex = 0;
            cbut.Text = "Concat";
            cbut.UseVisualStyleBackColor = true;
            cbut.Click += cbut_Click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.MenuText;
            b1.ForeColor = Color.Lime;
            b1.Location = new Point(42, 26);
            b1.Name = "b1";
            b1.PlaceholderText = "Add something";
            b1.Size = new Size(165, 23);
            b1.TabIndex = 1;
            b1.TextAlign = HorizontalAlignment.Center;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.MenuText;
            b2.ForeColor = Color.Lime;
            b2.Location = new Point(42, 67);
            b2.Name = "b2";
            b2.PlaceholderText = "Add something";
            b2.Size = new Size(165, 23);
            b2.TabIndex = 2;
            b2.TextAlign = HorizontalAlignment.Center;
            // 
            // output
            // 
            output.BackColor = SystemColors.InfoText;
            output.ForeColor = Color.Lime;
            output.Location = new Point(260, 26);
            output.Name = "output";
            output.Size = new Size(383, 64);
            output.TabIndex = 3;
            output.TabStop = false;
            output.Text = "";
            // 
            // swp
            // 
            swp.Location = new Point(264, 96);
            swp.Name = "swp";
            swp.Size = new Size(379, 62);
            swp.TabIndex = 4;
            swp.Text = "Swap";
            swp.UseVisualStyleBackColor = true;
            swp.Click += swp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 185);
            Controls.Add(swp);
            Controls.Add(output);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(cbut);
            Name = "Form1";
            Text = "CatOmine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cbut;
        private TextBox b1;
        private TextBox b2;
        private RichTextBox output;
        private Button swp;
    }
}