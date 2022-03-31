
namespace FreshersManagement.Model
{
    public class Trainee
    {
        public Trainee()
        {

        }

        public Trainee(string name, long mobileNumber, string qualification, string dob, string address)
        {
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

        public string Dob { get; set; }

        public string Address { get; set; }
    }
}

