using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FreshersManagement.Data;
using FreshersManagement.Model;

namespace FreshersManagement.Windows
{
    public partial class CreateForm : Form
    {
        IDataAccess dataAcces = new DataAccess();

        public CreateForm()
        {
            InitializeComponent();
        }

        private void Create_Click_1(object sender, EventArgs e)
        {
            string name = nameText.Text;
            long mobileNumber = Convert.ToInt64(mobileText.Text);
            string qualification = qualiText.Text;
            DateTime dob = DateTime.Parse(dobText.Text);
            string address = addressText.Text;
            Trainee trainee = new Trainee(name, mobileNumber, qualification, dob.ToString("yyyy-MM-dd"), address);
          
            if (idText.Text == "")
            {
                if (0 == dataAcces.InsertTrainee(trainee))
                {
                    MessageBox.Show("Mobile Number Already Exists");
                }
                else
                {
                    MessageBox.Show("Trainee Details Saved successfully!");
                }
            } else
            {
                trainee.Id = Convert.ToInt32(idText.Text);
                dataAcces.UpdateTrainee(trainee);
                MessageBox.Show("Trainee Details Updated successfully!");
            }
            Empty();
        }

        public void Empty()
        {
            idText.Text = " ";
            nameText.Text = " ";
            mobileText.Text = " ";
            qualiText.Text = " ";
            dobText.Text = null;
            addressText.Text = " ";
        }

        public void FetchValues(int id, string name, long mobileNumber, string qualification, DateTime dob, string address)
        {
            idText.Text = id.ToString();
            nameText.Text = name;
            mobileText.Text = mobileNumber.ToString();
            qualiText.Text = qualification;
            dobText.Text = dob.ToShortDateString();
            addressText.Text = address;
        }

        private void NameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameText.Text))
            {
                e.Cancel = true;
                nameText.Focus();
                errorProvider1.SetError(nameText, "Name should not be left blank!");
            }
            else if (!Regex.IsMatch(nameText.Text, @"^([a-zA-Z ]+)")) 
            {
                e.Cancel = true;
                nameText.Focus();
                errorProvider1.SetError(nameText, "Name does not contain symbols or numbers!");
            }
        }

        private void MobileText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mobileText.Text))
            {
                e.Cancel = true;
                mobileText.Focus();
                errorProvider1.SetError(mobileText, "Mobile Number should not be left blank!");
            }
            else if (!Regex.IsMatch(mobileText.Text, "^[6-9][0-9]{9}$"))
            {
                e.Cancel = true;
                mobileText.Focus();
                errorProvider1.SetError(mobileText, "Mobile Number does contain only 10 digit numbers!");
            }
        }
     
        private void DobText_Validating(object sender, CancelEventArgs e)
        {
            int age = (DateTime.Now.Subtract(dobText.Value).Days) / (365);
            if (age < 18)
            {
                e.Cancel = true;
                dobText.Focus();
                errorProvider1.SetError(dobText, "Age should be greater than 18");
            }
        }
    }
}
