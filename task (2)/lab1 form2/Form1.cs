using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            


        }

        string cb;
        string tb1;
        string tb2;





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            string name;
            name = textBox1.Text;
            label5.Visible = false;
            if (name.Length < 5)
            {
                label5.Visible = true;

            }
            else
            {
                label5.Visible = false;
                tb1 = "T";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            string email;


            email = textBox2.Text;


            label6.Visible = false;

            if (email.Contains("@"))
            {
                label6.Visible = false;
                tb2 = "T";



            }
            else
            {
                label6.Visible = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            bool hobby1Check = checkBox1.Checked;
            bool hobby2Check = checkBox2.Checked;
            bool hobby3Check = checkBox3.Checked;

            if (hobby1Check || hobby2Check || hobby3Check)
            {
                label7.Visible = false;
                cb = "T";
            }
               
            else
                label7.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1 == "T" && tb2 == "T" && cb == "T")
            {
                label8.Visible = true;

            }



        }


    }
}
