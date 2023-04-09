using System.Security.Cryptography.X509Certificates;

namespace _28ICWork
{
    public partial class Form1 : Form
    {
        int[] myarray = { 33, 55, 32, 1, 2, 3, 98, 357, 1259, 31, 9 };
        int[] narry = new int[100];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void b1_Click(object sender, EventArgs e)
        {/*    Bubble sort */
            output.Clear();
            for (int i = 0; i < myarray.Length; i++)
            {
                for (int j = i + 1; j < myarray.Length; j++)
                {
                    if (myarray[i] > myarray[j])
                    {
                        int tmp = myarray[j];
                        myarray[j] = myarray[i];
                        myarray[i] = tmp;
                    }
                }
            }
            for (int i = 0; i < myarray.Length; i++)
            {
                output.Text += $" {myarray[i]} ,";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            output.Clear();
            for (int i = 0; i < narry.Length; i++)
            {
                narry[i] = random.Next(1,1000);
                output.Text += $" {narry[i]}, ";
            }
        }
    }
}