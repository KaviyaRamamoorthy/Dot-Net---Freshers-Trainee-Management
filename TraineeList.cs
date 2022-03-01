using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Freshers_Management
{
    public class TraineeList
    {
        public static BindingList<Trainee> trainees = new BindingList<Trainee>();
        public int Id;

        public BindingList<Trainee> Save(Trainee trainee)
        { 
            trainees.Add(trainee);
            return trainees;      
        }

        public BindingList<Trainee> Display()
        {
            return trainees;
        }

        public void Update (Trainee trainee)
        {
            foreach (Trainee field in trainees)
            {
                if (Id == field.Id)
                {
                    field.Name = trainee.Name;
                    field.MobileNumber = trainee.MobileNumber;
                    field.Qualification = trainee.Qualification;
                    field.Dob = trainee.Dob;
                    field.Address = trainee.Address;
                }
            }
        }
    }
}
