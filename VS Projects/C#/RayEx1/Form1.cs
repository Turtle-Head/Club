using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Security;
using System.Text.Json.Serialization;

namespace RayEx1
{

    public partial class Form1 : Form
    {
        int[] twtp = new int[20];       //Array of 20 integer
        int[] narry = new int[100];     //Array of 100 integer
        Random random = new Random();   //Setup for random numbers
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool chkodd(int n) { if (n % 2 == 0) 
                return true;
            else return false;
        }
        private double avay(double tots, int lnt)
        {
            return (tots / lnt);
        }
        private double stot()
        {
            int tots = 0;
            for (int i = 0; i < narry.Length; i++)
            {
                output.Text += $"{narry[i]}, ";
                tots += narry[i];
            }
            return tots;
        }
       private bool zro(double n) { if (n == 0) return true;
            else return false; }
        private void b1_Click(object sender, EventArgs e)
        {   //Variable initialization
            int evn = 0;
            int odc = 0;
            int zr = 0;
            Double tots = 0;
            Double avg = 0;
            output.Clear();     //Making sure output box is empty
            for (int b = 0; b < narry.Length; b++)
            {
                narry[b] = random.Next(0, 100);
                if (zro(narry[b]) == true) { zr++; }
                else if (chkodd(narry[b])==true) { evn++; }
                else if (chkodd(narry[b])==false) { odc++; };
            }
            /*    Bubble sort */
            
            for (int i = 0; i < narry.Length; i++)
            {
                for (int j = i + 1; j < narry.Length; j++)
                {
                    if (narry[i] > narry[j])
                    {
                        int tmp = narry[j];
                        narry[j] = narry[i];
                        narry[i] = tmp;
                    }
                }
            }
            tots = stot();
            //for (int i = 0; i < narry.Length; i++)
            //{
            //    output.Text += $"{narry[i]}, ";
            //    tots += narry[i];
            //}
            int ln = narry.Length;
            avg = avay(tots, ln);
            output.Text += $"\n Even: {evn} \n Odd: {odc} \n Zeros: {zr}\n";
            output.Text += $"Sum: {tots}";
            output.Text += $"\n Average: {avg}";
            output.Text += $"\n Smallest: {narry[0]}";
            output.Text += $"\n Largest: {narry[narry.Length - 1]}";
        }
        
        private void twt_Click(object sender, EventArgs e)
        {
            int evn = 0;
            int odc = 0;
            int zr = 0;
            Double tots = 0;
            Double avg = 0;
            output.Clear();
            for (int b = 0; b < twtp.Length; b++)
            {
                twtp[b] = random.Next(0, 20);
                if (zro(twtp[b]) == true) { zr++; }
                else if ((chkodd(twtp[b]) == true )) { evn++; }
                else if ((chkodd(twtp[b]) == false)) { odc++; };
            }
            /*    Bubble sort */
           
            for (int i = 0; i < twtp.Length; i++)
            {
                for (int j = i + 1; j < twtp.Length; j++)
                {
                    if (twtp[i] > twtp[j])
                    {
                        int tmp = twtp[j];
                        twtp[j] = twtp[i];
                        twtp[i] = tmp;
                    }
                }
            }
            int ln = twtp.Length;
            for (int i = 0; i < ln; i++)
            {
                output.Text += $" {twtp[i]},";
                tots += twtp[i];
            }
            
            avg = avay(tots, ln);
            output.Text += $"\n Even: {evn} \n Odd: {odc} \n Zeros: {zr}\n";
            output.Text += $"Sum: {tots}";
            output.Text += $"\n Average: {avg}";
            output.Text += $"\n Smallest: {twtp[0]}";
            output.Text += $"\n Largest: {twtp[twtp.Length - 1]}";
        }
    }
}