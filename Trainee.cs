namespace FreshersManagement
{
    public class Trainee
    {
        public Trainee()
        {

        }
        public Trainee(int id, string name, long mobileNumber,
                string address, DateOnly dateOfBirth)
        {
            Id = id;
            Name = name;
            MobileNumber = mobileNumber;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", Id, Name, MobileNumber, Address, DateOfBirth);
        }
    }
}

