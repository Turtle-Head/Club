using System.Reflection.Metadata.Ecma335;
/* Title: V2 ref:-> https://github.com/Turtle-Head/CalculatorV2
 * Author: James Fehr
 * Written in C# 
 * For ITD General IT Programmer Exercise
 * Version 2 of Calculator project previously written in Visual Basic ref: https://github.com/Turtle-Head/Calculator-v6 
 **********************************************************************************************************************/
namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        Boolean deck = false;   /* decimal tracker */
string rat = "";        /* arithmatic operator */
        public Form1()
        {
            InitializeComponent();
        }

        private void clr_Click(object sender, EventArgs e)
        {   /* clear output textbox, reset decimal tracker */
            output.Clear();
            deck = false;
        }

        private void b0_Click(object sender, EventArgs e)
        {   /* sends 0 to output field */
            output.Text += "0";
        }

        private void decm_Click(object sender, EventArgs e)
        {   /* decimal tracker for output field */
            if (deck == false) /* checks if decimal tracker is active */
            {
                if (output.Text == "")
                {   /* adds 0 if output field empty before addind decimal */
                    output.Text = "0.";
                    deck = true;    /* decimal tracker activated */
                }
                else
                {   /* add decimal to current entry */
                    output.Text += ".";
                }

                deck = true;    /* decimal tracker activated */
            }

        }

        private void b1_Click(object sender, EventArgs e)
        {   /* sends 1 to output field */
            output.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {   /* sends 2 to output field */
            output.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {   /* sends 3 to output field */
            output.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {   /* sends 4 to output field */
            output.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {   /* sends 5 to output field */
            output.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {   /* sends 6 to output field */
            output.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {   /* sends 7 to output field */
            output.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {   /* sends 8 to output field */
            output.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {   /* sends 9 to output field */
            output.Text += "9";
        }

        private void adbut_Click(object sender, EventArgs e)
        {   /* Stores number, sets arithmatic, clears output field, resets decimal tracker */
            rat = "+";
            hist.Text = output.Text;
            output.Clear();
            deck = false;
        }
        private void equ_Click(object sender, EventArgs e)
        {   /* calculates arithmatic operations */
            double calc = Convert.ToDouble(hist.Text);
            double calc2 = Convert.ToDouble(output.Text);
            double result = 0;
            if (rat == "+") { result = calc + calc2; }
            else if (rat == "-") { result = calc - calc2; }
            else if (rat == "*") { result = calc * calc2; }
            else if (rat == "/") { result = calc / calc2; }
            else if (rat == "%") { result = calc % calc2; }
            output.Text = $"{result}";
            hist.Text = $"{calc} {rat} {calc2} = {result}";
        }

        private void minbut_Click(object sender, EventArgs e)
        {   /* Stores number, sets arithmatic, clears output field, resets decimal */
            rat = "-";
            hist.Text = output.Text;
            output.Clear();
            deck = false;
        }

        private void timesbut_Click(object sender, EventArgs e)
        {   /* Stores number, sets arithmatic, clears output field, resets decimal */
            rat = "*";
            hist.Text = output.Text;
            output.Clear();
            deck = false;
        }

        private void divbut_Click(object sender, EventArgs e)
        { /* Stores number, sets arithmatic, clears output field, resets decimal */
            rat = "/";
            hist.Text = output.Text;
            output.Clear();
            deck = false;
        }

        private void mo_Click(object sender, EventArgs e)
        {   /* Stores number, sets arithmatic, clears output field, resets decimal */
            rat = "%";
            hist.Text = output.Text;
            output.Clear();
            deck = false;
        }

        private void clrall_Click(object sender, EventArgs e)
        {   /* backspace output field */
            String result = output.Text;   /* stores textbox value */
          int ilenght = output.TextLength - 1;   /*gets length of string to trim last number */
            if (output.TextLength > 0) {  /* checking for 0 length to prevent crashing while backspacing */
                result = result.Substring(0, ilenght);   /* backspace */
                output.Text = result; /* update textbox value */
            }
        }

        private void clr_Click_1(object sender, EventArgs e)
        { /* Clears all fields, resets decimal*/
            output.Clear();
            hist.Clear();
            deck = false;
        }

        private void pn_Click(object sender, EventArgs e)
        {   /* change between positive & negative */
            double num = Convert.ToDouble(output.Text);
            output.Text = (-num).ToString();
        }
    }
}