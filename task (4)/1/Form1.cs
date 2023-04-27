using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab22_fform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>() { "blue", "Green", "Yellow", "Orange", "Red", "Brown" };
            comboBox1.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            switch (x)
            {
                case 0:
                    label1.ForeColor = Color.Blue;
                    break;
                case 1:
                    label1.ForeColor = Color.Green;
                    break;
                case 2:
                    label1.ForeColor = Color.Yellow;
                    break;
                case 3:
                    label1.ForeColor = Color.Orange;
                    break;
                case 4:
                    label1.ForeColor = Color.Red;
                    break;
                case 5:
                    label1.ForeColor = Color.Brown;
                    break;

            }
        }
    }
}
