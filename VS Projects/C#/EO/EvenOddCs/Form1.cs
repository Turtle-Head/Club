namespace EvenOddCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(ck.Text);
            if (N % 2 == 0) { output.Text = "Even"; }
            else { output.Text = "Odd"; }
        }
    }
}