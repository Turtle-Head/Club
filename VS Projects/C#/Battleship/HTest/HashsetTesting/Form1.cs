namespace HashsetTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }

            // Display all the numbers in the hash table.
            output.Text += $"numbers {0} elements: , {numbers.Count}";
            DisplaySet(numbers);

           // Remove all odd numbers.
           // numbers.RemoveWhere(IsOdd);
           // output.Text += ("numbers contains {0} elements: ", numbers.Count);
            //DisplaySet(numbers);

            // Check if the hash table contains 0 and, if so, remove it.
           // if (numbers.Contains(0))
            //{
            //    numbers.Remove(0);
            //}
           // output.Text += ("numbers removals of odd numbers {0} elements: ", numbers.Count);
           // DisplaySet(numbers);

            //bool IsOdd(int i)
            //{
            //    return ((i % 2) == 1);
            //}

            void DisplaySet(HashSet<int> set)
            {
                foreach (int i in set)
                    output.Text += ($"{set}", i);

            }

            // This example displays the following output:
            //    numbers contains 20 elements: { 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 }
            //    numbers contains 10 elements: { 0 2 4 6 8 10 12 14 16 18 }
            //    numbers contains 9 elements: { 2 4 6 8 10 12 14 16 18 }
        }
    }
}