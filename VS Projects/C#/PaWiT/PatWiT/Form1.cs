using System.Xml.XPath;

namespace PatWiT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fact_Click(object sender, EventArgs e)
        {
            output.Clear();
            double num = Convert.ToDouble(num1.Text);
            double tots = 1;
            for (double i = num; i > 0; i--)
            {
                tots *= i;
                output.Text += $"{tots}\n";
            }
            output.Text += $"{num} : {tots}\n";
        }
        private double powerof(double num, double pnum)
        {
            for (double i = pnum; i > 0; i--)
            {
                num *= num;
            }
            return num;
        }
        private void Power_Click(object sender, EventArgs e)
        {
            output.Clear();
            double n1 = Convert.ToDouble(num2.Text);
            double pn = Convert.ToDouble(num3.Text);
            double tots = 1;
            for(double i = pn; i> 0; i--) {
                tots *= n1;
                output.Text +=$"{i}:{tots}\n";
            }
            output.Text += $"{n1}:*{pn} {tots}\n";
        }
    }
}