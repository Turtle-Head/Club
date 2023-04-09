namespace CatOmine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbut_Click(object sender, EventArgs e)
        {
            string box1 = b1.Text;
            string box2 = b2.Text;
            output.Text = $"{box1} {box2}";
            MessageBox.Show($"{box1} {box2}");
            cbut.Text = $"{box1} {box2}";
            cbut.ForeColor = Color.Lime;
            cbut.BackColor = Color.DarkViolet;
        }

        private void swp_Click(object sender, EventArgs e)
        {
            string tmp = b1.Text;
            b1.Text = b2.Text;
            b2.Text = tmp;
            swp.ForeColor = Color.Lime;
            swp.BackColor = Color.DarkViolet;
        }
    }
}