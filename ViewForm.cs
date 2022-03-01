using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace Freshers_Management
{
    public partial class ViewForm : Form
    {
        BindingList<Trainee> trainees = new TraineeList().Display(); 

        public ViewForm()
        {
            InitializeComponent();
            View();
        }

        public void View()
        {
            dataGridView1.DataSource = trainees;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                  int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    string name = row.Cells[1].Value.ToString();
                    long mobileNumber = Convert.ToInt64(row.Cells[2].Value.ToString());
                    string qualification = row.Cells[3].Value.ToString();
                    DateTime dob = DateTime.Parse(row.Cells[4].Value.ToString());
                    string address = row.Cells[5].Value.ToString();

                    createForm.FetchValues(id, name, mobileNumber, qualification, dob, address);
                
                createForm.ShowDialog();
                dataGridView1.Refresh();
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            trainees.RemoveAt(selectedRow);
        }
    }
}
