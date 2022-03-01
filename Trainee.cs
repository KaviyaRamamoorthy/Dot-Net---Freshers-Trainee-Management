using System;

namespace Freshers_Management
{
    
    public class Trainee
    {
        public Trainee(int id, string name, long mobileNumber, string qualification, DateTime dob, string address)
        {
            Id = id;
            Name = name;
            MobileNumber = mobileNumber;
            Qualification = qualification;
            Dob = dob;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Qualification { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
    }
}
