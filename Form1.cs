using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshers_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TraineeList traineeList = new TraineeList();
           
            CreateForm createForm = new CreateForm();
            traineeList.Id++;
            createForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }
    }
}
