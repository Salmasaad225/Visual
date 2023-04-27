using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3_w_f
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
             form2  = new Form2(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            form2.Show();
            form2.styling += Text_changed;
           

        }

        private void Text_changed(object sender, EventArgs e)
        {
            textBox1.ForeColor = form2.color;
            Font f = new Font(form2.f_name, form2.f_size);
            textBox1.Font = f ;

        }
    }
}
