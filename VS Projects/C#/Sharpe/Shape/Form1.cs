using System;

namespace Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addb_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToInt32(num1.Text);
            Double n2 = Convert.ToInt32(num2.Text);
            Double Total = n1 + n2;
            output.Text = Total.ToString();
            addb.BackColor = Color.DarkViolet;
            addb.ForeColor = Color.Lime;
        }

        private void dif_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToInt32(num1.Text);
            Double n2 = Convert.ToInt32(num2.Text);
            Double Total = n1 - n2;
            output.Text = Total.ToString();
            dif.BackColor = Color.Lime;
            dif.ForeColor = Color.DarkViolet;
        }

        private void div_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToInt32(num1.Text);
            Double n2 = Convert.ToInt32(num2.Text);
            Double Total = n1 / n2;
            output.Text = Total.ToString();
            div.BackColor = Color.DarkViolet;
            div.ForeColor = Color.Lime;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToInt32(num1.Text);
            Double n2 = Convert.ToInt32(num2.Text);
            Double Total = n1 * n2;
            output.Text = Total.ToString();
            mult.BackColor = Color.Lime;
            mult.ForeColor = Color.DarkViolet;
        }

        private void mb_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToInt32(num1.Text);
            Double n2 = Convert.ToInt32(num2.Text);
            Double Total = n1 % n2;
            output.Text = Total.ToString();
            mb.Text = "% mod %";
            mb.BackColor = Color.DarkViolet;
            mb.ForeColor = Color.Lime;
        }

        private void swp_Click(object sender, EventArgs e)
        {
            String tmp = num1.Text;
            num1.Text = num2.Text;
            num2.Text = tmp;
            swp.BackColor = Color.Lime;
            swp.ForeColor = Color.DarkViolet;
            swp.Text = "Swapped";
        }


    }
}