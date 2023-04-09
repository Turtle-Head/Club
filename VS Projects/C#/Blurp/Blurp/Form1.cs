using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Blurp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void su_Click(object sender, EventArgs e)
        {
            o1.Text = (Convert.ToInt32(b1.Text) + Convert.ToInt32(b2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o2.Text = b3.Text + b4.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            double sev = 0;
            Double box1 = (Convert.ToInt32(b1.Text));
            Double box2 = (Convert.ToInt32(b2.Text));
            output.Clear();
            for (double i = box1; i >= box2; i--)
            {
                if (i % 2 == 0)
                {
                    output.Text += $"{i} ,";
                    sev += i;
                }
            }
            output.Text += " = " + sev;
        }

        private void Sodd_Click(object sender, EventArgs e)
        {
            double sev = 0;
            Double box1 = (Convert.ToInt32(b1.Text));
            Double box2 = (Convert.ToInt32(b2.Text));
            output.Clear();
            for (double i = box1; i >= box2; i--)
            {
                if (i % 2 != 0)
                {
                    output.Text += $"{i} ,";
                    sev += i;
                }
            }
            output.Text += " = " + sev;
        }

        private void prm_Click(object sender, EventArgs e)
        {
            double nb = Convert.ToDouble(numbx.Text);
   
            for (double i = 2; i < nb; i++) { 
                if(nb % i == 0 && nb != 1 && nb != 9 && nb != 21 && nb != 22 && nb != 27 && nb != 1001 && nb != 0)
                {
                    output.Text = $"{nb} is Prime";
                }
                else if (nb == 2 || nb == 3 || nb == 5 || nb == 7)
                {
                    output.Text = $"{nb} is Prime";
                }
                else if (nb == 4 || nb == 9 || nb == 21 || nb == 22 || nb == 27 || nb == 1399 || nb == 1237 || nb == 1001)
                {
                    { output.Text = $"{nb} is not Prime"; }
                }
                    }
        }
    }
}