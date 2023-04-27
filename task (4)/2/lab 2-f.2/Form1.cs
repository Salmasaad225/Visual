using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_f._2
{
    //public class employee
    //{
    //    public string name { set; get; }
    //    public int phone { set; get; }
    //    public string date { set; get; }
    //}
    public partial class Form1 : Form
    {
        //employee[] employees;

        //employee emp = new employee();
        //employee emp2 = new employee();
        //employee emp3 = new employee();


        public Form1()
        {
            InitializeComponent();
            //employees = new employee[5];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1, textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString());
            dataGridView1.Rows.Add(row);





        }

       
    } 
}

