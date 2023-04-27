using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_form
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //string nums;
            ////double value;

            //if (radioButton1.Checked)
            //{
            //    nums = textBox1.Text;
            //    //nums(int);
            //    textBox2.Text = nums;



            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //string nums;
            ////double value;

            //if (radioButton2.Checked)
            //{
            //    nums = textBox1.Text;
            //    //nums(int);
            //    textBox2.Text = nums;



            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nums;
            //double value =0;
           

            if (radioButton1.Checked)
            {
                double num = double.Parse(textBox1.Text);
                num=num/1000;
                textBox2.Text = num .ToString();
              

            }

            if (radioButton2.Checked)
            {
                double num = double.Parse(textBox1.Text);
                num = num * 1000*1.6;
                textBox2.Text = num.ToString();

            }
            if (radioButton3.Checked)
            {
                double num = double.Parse(textBox1.Text);
                num = num / 1000 / 1.6;
                textBox2.Text = num.ToString();

            }



        }
    }
}
