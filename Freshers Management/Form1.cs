﻿using System;
using System.Windows.Forms;

namespace FreshersManagement.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }
    }
}
