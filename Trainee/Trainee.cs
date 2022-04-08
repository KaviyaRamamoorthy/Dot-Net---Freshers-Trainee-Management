
using System.ComponentModel.DataAnnotations;

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

        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^((\\+91)|0)?[6-9][0-9]{9}$", ErrorMessage = "Entered phone format is not valid")]
        public long MobileNumber { get; set; }

        [Required]
        public string Qualification { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required]
        public string Dob { get; set; }

        [Required]
        public string Address { get; set; }
    }
}

