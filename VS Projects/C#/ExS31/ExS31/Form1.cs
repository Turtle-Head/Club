namespace ExS31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void stra(double n1, double n2)
        {
            double sum = n1 - n2;
            output.Text += $"{n1} - {n2} = {sum}\n";
        }
        public void quto(double n1, double n2)
        {
            double sum = n1 / n2;
            output.Text += $"{n1} / {n2} = {sum}\n";
        }
        public void mtp(double n1, double n2)
        {
            double sum = n1 * n2;
            output.Text += $"{n1} * {n2} = {sum}\n";
        }
        public void calt(double n1, double n2)
        {

            double sum = n1 + n2;
            output.Text += $"{n1} + {n2} = {sum}\n";
        }
        private void s1_Click(object sender, EventArgs e)
        {
            // sends num1 and num2 to sum function
            calt(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            calt(10, 5);    // sum 2 numbers
            stra(10, 5);    // subtract 2nd number from first number 
            mtp(10, 5);     // multiply 2 numbers
            quto(10, 5);    // divide first number by second number
        }

        private void multp_Click(object sender, EventArgs e) // multiply
        {
            // sends num1 and num2 to multiply function
            mtp(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
        }

        private void divi_Click(object sender, EventArgs e)  // divide
        {
            // sends num1 and num2 to divide function
            quto(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
        }

        private void suts_Click(object sender, EventArgs e) //subtract
        {
            // sends num1 and num2 to subtract function
            stra(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
        }

        public void clck()
        {
            // clear all textboxes
            output.Clear();
            num1.Clear();
            num2.Clear();
        }

        private void CB_Click(object sender, EventArgs e)
        {
            // clear all textboxes
            clck();
        }
    }
}