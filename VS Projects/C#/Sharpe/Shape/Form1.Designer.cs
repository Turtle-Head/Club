namespace Shape
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
            num1 = new TextBox();
            num2 = new TextBox();
            addb = new Button();
            dif = new Button();
            div = new Button();
            mult = new Button();
            output = new RichTextBox();
            mb = new Button();
            swp = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.BackColor = SystemColors.MenuText;
            num1.ForeColor = Color.Lime;
            num1.Location = new Point(45, 47);
            num1.Name = "num1";
            num1.PlaceholderText = "Number 1";
            num1.Size = new Size(158, 23);
            num1.TabIndex = 0;
            num1.TextAlign = HorizontalAlignment.Center;
            // 
            // num2
            // 
            num2.BackColor = SystemColors.InfoText;
            num2.ForeColor = Color.Lime;
            num2.Location = new Point(45, 96);
            num2.Name = "num2";
            num2.PlaceholderText = "Number 2";
            num2.Size = new Size(158, 23);
            num2.TabIndex = 1;
            num2.TextAlign = HorizontalAlignment.Center;
            // 
            // addb
            // 
            addb.Location = new Point(209, 47);
            addb.Name = "addb";
            addb.Size = new Size(75, 23);
            addb.TabIndex = 2;
            addb.Text = "Add +";
            addb.UseVisualStyleBackColor = true;
            addb.Click += addb_Click;
            // 
            // dif
            // 
            dif.Location = new Point(209, 92);
            dif.Name = "dif";
            dif.Size = new Size(75, 23);
            dif.TabIndex = 3;
            dif.Text = "Minus -";
            dif.UseVisualStyleBackColor = true;
            dif.Click += dif_Click;
            // 
            // div
            // 
            div.Location = new Point(209, 140);
            div.Name = "div";
            div.Size = new Size(75, 23);
            div.TabIndex = 4;
            div.Text = "Divide /";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // mult
            // 
            mult.Location = new Point(209, 178);
            mult.Name = "mult";
            mult.Size = new Size(75, 23);
            mult.TabIndex = 5;
            mult.Text = "Multiply  x";
            mult.UseVisualStyleBackColor = true;
            mult.Click += mult_Click;
            // 
            // output
            // 
            output.BackColor = SystemColors.MenuText;
            output.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            output.ForeColor = Color.Lime;
            output.Location = new Point(45, 140);
            output.Name = "output";
            output.ScrollBars = RichTextBoxScrollBars.None;
            output.Size = new Size(158, 133);
            output.TabIndex = 6;
            output.TabStop = false;
            output.Text = "";
            // 
            // mb
            // 
            mb.Location = new Point(209, 211);
            mb.Name = "mb";
            mb.Size = new Size(75, 23);
            mb.TabIndex = 6;
            mb.Text = "Mod %";
            mb.UseVisualStyleBackColor = true;
            mb.Click += mb_Click;
            // 
            // swp
            // 
            swp.Location = new Point(209, 250);
            swp.Name = "swp";
            swp.Size = new Size(75, 23);
            swp.TabIndex = 7;
            swp.Text = "Swap";
            swp.UseVisualStyleBackColor = true;
            swp.Click += swp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 313);
            Controls.Add(swp);
            Controls.Add(mb);
            Controls.Add(output);
            Controls.Add(mult);
            Controls.Add(div);
            Controls.Add(dif);
            Controls.Add(addb);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Sharpe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1;
        private TextBox num2;
        private Button addb;
        private Button dif;
        private Button div;
        private Button mult;
        private RichTextBox output;
        private Button mb;
        private Button swp;
    }
}