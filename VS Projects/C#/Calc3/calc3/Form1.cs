using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace calc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void cclk()
        {
            output.Clear();
            num1.Clear();
            num2.Clear();
            op.Clear();
        }
        private void CL_Click(object sender, EventArgs e)
        {
            cclk();
        }

        private void cks_Click(object sender, EventArgs e)
        {

            double ctot = Ctotal(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text), op.Text);
            output.Text = ctot.ToString();

        }
        private double Ctotal(double n1, double n2, string opt)
        {
            if (opt == "+")
            {
                return n1 + n2;
            }
            else if (opt == "-")
            {
                return n2 - n1;
            }
            else if (opt == "*")
            {
                return n1 * n2;
            }
            else if (opt == "/")
            {
                return n1 / n2;
            }
            else if (opt == "%")
                return n1 % n2;
            else return 0;
        }
    }
}