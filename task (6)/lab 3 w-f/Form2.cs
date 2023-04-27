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
    public partial class Form2 : Form
    {
        public event EventHandler styling;
        Color custum;

        public int f_size 
        {
            get
            {
                return (int) numericUpDown1.Value;
            }
        }

        public string f_name
        {
            get
            {
               return (string) comboBox1.SelectedItem;
            }
        }

        public Color color
        {
            get
            {
                if(radioButton1.Checked)
                {
                    return Color.Red;
                }
                else if (radioButton2.Checked)
                {
                    return Color.Blue;
                }
                else if (radioButton3.Checked)
                {
                    return custum;
                }

                return Color.Black ;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (styling != null)
            {
                styling(sender, null);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            if(colordialog.ShowDialog()==DialogResult.OK)
            {
                custum = colordialog.Color;


            }
        }
    }
}
