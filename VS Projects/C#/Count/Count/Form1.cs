namespace Count
{
    public partial class Form1 : Form
    {
        double sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {

            for (double i = 0; i <= 100; i++)
            {
                if (i == 100) {
                    sum += i;
                    tb.Text += $"{sum} "; 
            }else
                {
                    sum += i;
                    tb.Text += $"{sum}, ";
                }
                
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            tb.Clear();
            sum = 0;
        }
    }
}