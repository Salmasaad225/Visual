﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
       businessLayer businessLayer = new businessLayer();
        public Form1()
        {
            InitializeComponent();
           

            dataGridView1.DataSource = businessLayer.GetDepartments();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Dname = textBox1.Text;
            int Dno = int.Parse(textBox2.Text);
            businessLayer.InsertDepartment(Dname, Dno);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.GetDepartments();

           
        }
    }
}
