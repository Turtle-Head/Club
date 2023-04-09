namespace CalculatorV2
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
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b0 = new Button();
            adbut = new Button();
            minbut = new Button();
            timesbut = new Button();
            divbut = new Button();
            decm = new Button();
            output = new TextBox();
            hist = new TextBox();
            equ = new Button();
            mo = new Button();
            clr = new Button();
            clrall = new Button();
            pn = new Button();
            SuspendLayout();
            // 
            // b7
            // 
            b7.Location = new Point(28, 140);
            b7.Name = "b7";
            b7.Size = new Size(29, 23);
            b7.TabIndex = 1;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(63, 140);
            b8.Name = "b8";
            b8.Size = new Size(29, 23);
            b8.TabIndex = 2;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(98, 140);
            b9.Name = "b9";
            b9.Size = new Size(29, 23);
            b9.TabIndex = 3;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b4
            // 
            b4.Location = new Point(28, 169);
            b4.Name = "b4";
            b4.Size = new Size(29, 23);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(63, 169);
            b5.Name = "b5";
            b5.Size = new Size(29, 23);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(98, 169);
            b6.Name = "b6";
            b6.Size = new Size(29, 23);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b1
            // 
            b1.Location = new Point(28, 198);
            b1.Name = "b1";
            b1.Size = new Size(29, 23);
            b1.TabIndex = 7;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(63, 198);
            b2.Name = "b2";
            b2.Size = new Size(29, 23);
            b2.TabIndex = 8;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(98, 198);
            b3.Name = "b3";
            b3.Size = new Size(29, 23);
            b3.TabIndex = 9;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b0
            // 
            b0.Location = new Point(63, 227);
            b0.Name = "b0";
            b0.Size = new Size(29, 23);
            b0.TabIndex = 10;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // adbut
            // 
            adbut.Location = new Point(133, 140);
            adbut.Name = "adbut";
            adbut.Size = new Size(29, 23);
            adbut.TabIndex = 11;
            adbut.Text = "+";
            adbut.UseVisualStyleBackColor = true;
            adbut.Click += adbut_Click;
            // 
            // minbut
            // 
            minbut.Location = new Point(133, 169);
            minbut.Name = "minbut";
            minbut.Size = new Size(29, 23);
            minbut.TabIndex = 12;
            minbut.Text = "-";
            minbut.UseVisualStyleBackColor = true;
            minbut.Click += minbut_Click;
            // 
            // timesbut
            // 
            timesbut.Location = new Point(133, 198);
            timesbut.Name = "timesbut";
            timesbut.Size = new Size(29, 23);
            timesbut.TabIndex = 13;
            timesbut.Text = "*";
            timesbut.UseVisualStyleBackColor = true;
            timesbut.Click += timesbut_Click;
            // 
            // divbut
            // 
            divbut.Location = new Point(133, 227);
            divbut.Name = "divbut";
            divbut.Size = new Size(29, 23);
            divbut.TabIndex = 14;
            divbut.Text = "/";
            divbut.UseVisualStyleBackColor = true;
            divbut.Click += divbut_Click;
            // 
            // decm
            // 
            decm.Location = new Point(98, 227);
            decm.Name = "decm";
            decm.Size = new Size(27, 23);
            decm.TabIndex = 16;
            decm.Text = ".";
            decm.UseVisualStyleBackColor = true;
            decm.Click += decm_Click;
            // 
            // output
            // 
            output.BackColor = SystemColors.MenuText;
            output.Font = new Font("Gill Sans MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            output.ForeColor = Color.Lime;
            output.Location = new Point(28, 57);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(134, 35);
            output.TabIndex = 17;
            output.TabStop = false;
            output.TextAlign = HorizontalAlignment.Center;
            // 
            // hist
            // 
            hist.BackColor = SystemColors.ControlLightLight;
            hist.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hist.ForeColor = SystemColors.GrayText;
            hist.Location = new Point(28, 25);
            hist.Name = "hist";
            hist.PlaceholderText = "History";
            hist.ReadOnly = true;
            hist.Size = new Size(134, 26);
            hist.TabIndex = 18;
            hist.TextAlign = HorizontalAlignment.Center;
            // 
            // equ
            // 
            equ.Location = new Point(28, 256);
            equ.Name = "equ";
            equ.Size = new Size(94, 25);
            equ.TabIndex = 19;
            equ.Text = "=";
            equ.UseVisualStyleBackColor = true;
            equ.Click += equ_Click;
            // 
            // mo
            // 
            mo.Location = new Point(133, 256);
            mo.Name = "mo";
            mo.Size = new Size(29, 25);
            mo.TabIndex = 20;
            mo.Text = "%";
            mo.UseVisualStyleBackColor = true;
            mo.Click += mo_Click;
            // 
            // clr
            // 
            clr.Location = new Point(98, 110);
            clr.Name = "clr";
            clr.Size = new Size(64, 24);
            clr.TabIndex = 21;
            clr.Text = "CA";
            clr.UseVisualStyleBackColor = true;
            clr.Click += clr_Click_1;
            // 
            // clrall
            // 
            clrall.Location = new Point(28, 227);
            clrall.Name = "clrall";
            clrall.Size = new Size(29, 23);
            clrall.TabIndex = 22;
            clrall.Text = "bk";
            clrall.UseVisualStyleBackColor = true;
            clrall.Click += clrall_Click;
            // 
            // pn
            // 
            pn.Location = new Point(28, 111);
            pn.Name = "pn";
            pn.Size = new Size(64, 23);
            pn.TabIndex = 23;
            pn.Text = "+/-";
            pn.UseVisualStyleBackColor = true;
            pn.Click += pn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vector_2483061_960_720;
            ClientSize = new Size(192, 292);
            Controls.Add(pn);
            Controls.Add(clrall);
            Controls.Add(clr);
            Controls.Add(mo);
            Controls.Add(equ);
            Controls.Add(hist);
            Controls.Add(output);
            Controls.Add(decm);
            Controls.Add(divbut);
            Controls.Add(timesbut);
            Controls.Add(minbut);
            Controls.Add(adbut);
            Controls.Add(b0);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Name = "Form1";
            Text = "V2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b0;
        private Button adbut;
        private Button minbut;
        private Button timesbut;
        private Button divbut;
        private Button decm;
        private TextBox output;
        private TextBox hist;
        private Button equ;
        private Button mo;
        private Button clr;
        private Button clrall;
        private Button pn;
    }
}