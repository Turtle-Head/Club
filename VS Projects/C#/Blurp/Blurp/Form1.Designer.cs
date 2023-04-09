namespace Blurp
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
            su = new Button();
            button2 = new Button();
            b1 = new TextBox();
            b2 = new TextBox();
            b3 = new TextBox();
            b4 = new TextBox();
            o1 = new TextBox();
            o2 = new TextBox();
            Seven = new Button();
            Sodd = new Button();
            output = new RichTextBox();
            prm = new Button();
            numbx = new TextBox();
            SuspendLayout();
            // 
            // su
            // 
            su.Location = new Point(30, 87);
            su.Name = "su";
            su.Size = new Size(100, 23);
            su.TabIndex = 0;
            su.Text = "Sum";
            su.UseVisualStyleBackColor = true;
            su.Click += su_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 87);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Concat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // b1
            // 
            b1.Location = new Point(30, 29);
            b1.Name = "b1";
            b1.PlaceholderText = "Add Number";
            b1.Size = new Size(100, 23);
            b1.TabIndex = 2;
            b1.TextAlign = HorizontalAlignment.Center;
            // 
            // b2
            // 
            b2.Location = new Point(30, 58);
            b2.Name = "b2";
            b2.PlaceholderText = "Add Number";
            b2.Size = new Size(100, 23);
            b2.TabIndex = 3;
            b2.TextAlign = HorizontalAlignment.Center;
            // 
            // b3
            // 
            b3.Location = new Point(158, 29);
            b3.Name = "b3";
            b3.PlaceholderText = "Add Number";
            b3.Size = new Size(100, 23);
            b3.TabIndex = 4;
            b3.TextAlign = HorizontalAlignment.Center;
            // 
            // b4
            // 
            b4.Location = new Point(158, 58);
            b4.Name = "b4";
            b4.PlaceholderText = "Add Number";
            b4.Size = new Size(100, 23);
            b4.TabIndex = 5;
            b4.TextAlign = HorizontalAlignment.Center;
            // 
            // o1
            // 
            o1.Location = new Point(30, 116);
            o1.Name = "o1";
            o1.Size = new Size(98, 23);
            o1.TabIndex = 6;
            o1.TextAlign = HorizontalAlignment.Center;
            // 
            // o2
            // 
            o2.Location = new Point(158, 116);
            o2.Name = "o2";
            o2.Size = new Size(100, 23);
            o2.TabIndex = 7;
            o2.TextAlign = HorizontalAlignment.Center;
            // 
            // Seven
            // 
            Seven.Location = new Point(30, 151);
            Seven.Name = "Seven";
            Seven.Size = new Size(98, 23);
            Seven.TabIndex = 8;
            Seven.Text = "SumEven";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Sodd
            // 
            Sodd.Location = new Point(158, 152);
            Sodd.Name = "Sodd";
            Sodd.Size = new Size(100, 23);
            Sodd.TabIndex = 9;
            Sodd.Text = "SumOdd";
            Sodd.UseVisualStyleBackColor = true;
            Sodd.Click += Sodd_Click;
            // 
            // output
            // 
            output.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(30, 195);
            output.Name = "output";
            output.Size = new Size(228, 93);
            output.TabIndex = 10;
            output.Text = "";
            // 
            // prm
            // 
            prm.Location = new Point(280, 251);
            prm.Name = "prm";
            prm.Size = new Size(101, 23);
            prm.TabIndex = 11;
            prm.Text = "is Prime ?";
            prm.UseVisualStyleBackColor = true;
            prm.Click += prm_Click;
            // 
            // numbx
            // 
            numbx.Location = new Point(281, 210);
            numbx.Name = "numbx";
            numbx.PlaceholderText = "Is Prime?";
            numbx.Size = new Size(100, 23);
            numbx.TabIndex = 12;
            numbx.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 311);
            Controls.Add(numbx);
            Controls.Add(prm);
            Controls.Add(output);
            Controls.Add(Sodd);
            Controls.Add(Seven);
            Controls.Add(o2);
            Controls.Add(o1);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(button2);
            Controls.Add(su);
            Name = "Form1";
            Text = "Blurp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button su;
        private Button button2;
        private TextBox b1;
        private TextBox b2;
        private TextBox b3;
        private TextBox b4;
        private TextBox o1;
        private TextBox o2;
        private Button Seven;
        private Button Sodd;
        private RichTextBox output;
        private Button prm;
        private TextBox numbx;
    }
}