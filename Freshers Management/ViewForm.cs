using System;
using System.Windows.Forms;
using FreshersManagement.Data;

namespace FreshersManagement.Windows
{
    public partial class ViewForm : Form
    {
        IDataAccess dataAcces = new DataAccess();

        public ViewForm()
        {
            InitializeComponent();
            View();
        }

        public void View()
        {
           dataGridView1.DataSource = dataAcces.FetchTrainee();
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
                View();
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dataAcces.DeleteTrainee(id);
            View();
        }
    }
}
