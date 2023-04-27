using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_3
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();


            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedListBox2.Items.Add(item);
                indexes.Add(checkedListBox1.CheckedItems.IndexOf(item));



            }

            foreach (int item in indexes)
            {
                checkedListBox1.Items.RemoveAt(item);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                checkedListBox2.Items.Add(item);

            }
            checkedListBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();

            foreach (var item in checkedListBox2.CheckedItems)
            {
                checkedListBox1.Items.Add(item);
                indexes.Add(checkedListBox2.CheckedItems.IndexOf(item));



            }

            foreach (int item in indexes)
            {
                checkedListBox2.Items.RemoveAt(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox2.Items)
            {
                checkedListBox1.Items.Add(item);

            }
            checkedListBox2.Items.Clear();
        }
    }


}
