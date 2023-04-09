namespace FBrework
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

        private void b1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(num.Text);
            if (n % 3 == 0 && n % 5 == 0)
            {
                output.Text = "FizzBuzz";
            }
            else if (n % 3 == 0 && n % 5 != 0)
            {
                output.Text = "Fizz";
            }
            else if (n % 3 != 0 &&  n % 5 == 0)
            {
                output.Text = "Buzz";
            }
            else { output.Text = "No Fizz No Buzz"; }
        }
    }
}