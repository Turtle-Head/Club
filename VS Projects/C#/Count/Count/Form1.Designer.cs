namespace Count
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
            tb = new RichTextBox();
            b1 = new Button();
            clr = new Button();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(28, 21);
            tb.Name = "tb";
            tb.Size = new Size(320, 175);
            tb.TabIndex = 0;
            tb.Text = "";
            // 
            // b1
            // 
            b1.BackColor = SystemColors.HotTrack;
            b1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            b1.ForeColor = Color.Lime;
            b1.Location = new Point(30, 218);
            b1.Name = "b1";
            b1.Size = new Size(131, 38);
            b1.TabIndex = 1;
            b1.Text = "Start";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // clr
            // 
            clr.BackColor = Color.MidnightBlue;
            clr.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clr.ForeColor = Color.Red;
            clr.Location = new Point(177, 218);
            clr.Name = "clr";
            clr.Size = new Size(146, 38);
            clr.TabIndex = 2;
            clr.Text = "Clear";
            clr.UseVisualStyleBackColor = false;
            clr.Click += clr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.textured_1736872_960_720;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(379, 282);
            Controls.Add(clr);
            Controls.Add(b1);
            Controls.Add(tb);
            Name = "Form1";
            Text = "Sum";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox tb;
        private Button b1;
        private Button clr;
    }
}