using System;

namespace MiniATM
{
    public partial class Form1 : Form
    {
        Random random = new Random();   //Setup for random numbers
        //double balc = random.Next(1, 100000);
        double balc = 100000000;



        public Form1()
        {
            InitializeComponent();
        }

        private void balck_Click(object sender, EventArgs e)
        {

            output.Clear();
            output.Text += $" $ {balc}";
        }

        private void wd_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num.Text);
            balc -= n1;
            string text = $"WD:{n1} \n Recipt \n Balance $ {balc}";
            MessageBox.Show(text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void depos_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num.Text);
            balc += n1;
            string text = $"CR:{n1} \n Recipt \n Balance $ {balc}";
            MessageBox.Show(text);
        }
    }
}