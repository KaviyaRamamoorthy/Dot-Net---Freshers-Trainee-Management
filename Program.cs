using System;
using System.Text;

namespace FreshersManagement
{
    public class FreshersManagement
    {
        public static void Main(string[] args)
        {
            FreshersManagement freshersManagement = new FreshersManagement();
            freshersManagement.GetUserChoice();
        }

        public void GetUserChoice()
        {
            int choice = 0;
            do
            {
                Console.Write("1. Create\n2. View\n3. Search\n4. Exit\nEnter Your Choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CreateTrainee();
                            break;
                        case 2:
                            ViewTrainee();
                            break;
                        case 3:
                            SearchTrainee();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Invalide Choice....!!! Please Enter Correct Choice...!!!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter valid choice: ");
                }
            } while (4 != choice);
        }

        public void CreateTrainee()
        {              
            List<Trainee> trainees = new List<Trainee>();
            FileStream fileStream = new FileStream(@"C:\Users\Lenovo\Desktop\.net\FreshersTraineeManagement\trainee.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            Console.Write("Number of trainees want to create: ");
            int count = 0;
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                GetDetails(trainees);
                count++;
            } 
           
            foreach (var i in trainees)
                streamWriter.WriteLine(i);
            Console.WriteLine("Trainee Details Added Successfully...!!!!:\n");
       
            streamWriter.Close();
            fileStream.Close();
        }

        private void GetDetails(List<Trainee> trainees)
        {
            int id;
            string name;
            long mobileNumber;
            string address;
            DateOnly dateOfBirth;

            id = (int)GetId();
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            mobileNumber = GetMobileNumber();
            Console.Write("Enter Addess: ");
            address = Console.ReadLine();
            dateOfBirth = GetDateOfBirth();

            Trainee trainee = new Trainee(id, name, mobileNumber, address, dateOfBirth);
            trainees.Add(trainee);
        }

        private long GetId()
        {
            bool isValid = false;
            int id = 1;
            Console.Write("Enter Id: ");
 
            while (!isValid)
            {
                try
                {
                    id = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Enter Id in numerics: ");
                }
            }
            return id;
        }

        private long GetMobileNumber()
        {
            bool isValid = false;
            long mobileNumber = 0;
            Console.Write("Enter Mobile Number: ");

            while (!isValid)
            {
                try
                {
                    mobileNumber = long.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Enter Mobile Number in numerics: ");
                }

            }
            return mobileNumber;
        }

        private DateOnly GetDateOfBirth()
        {
            bool isValid = false;
            DateOnly dateOfBirth;
            Console.Write("Enter Date of birth: ");

            while (!isValid)
            {
                try
                {
                    dateOfBirth = DateOnly.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Enter date of birth in dd/MM/yyyy format: ");
                }

            }
            return dateOfBirth;
        }

        private int CalculateAge(DateOnly dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        public void ViewTrainee()
        {
            FileStream fileStream = new FileStream(@"C:\Users\Lenovo\Desktop\.net\FreshersTraineeManagement\trainee.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string data = streamReader.ReadLine();

            while (data != null)
            {
                string[] values = data.Split(", ");
                int id = int.Parse(values[0]);
                string name = values[1];
                string mobileNumber = values[2];
                string address = values[3];
                DateOnly dateOfBirth = DateOnly.Parse(values[4]);
                int age = CalculateAge(dateOfBirth);
                Console.WriteLine("\nId: {0}\nName: {1}\nMobile number: {2}\nAddress: {3}\nDate of birth: {4}\nAge: {5}\n",
                    id, name, mobileNumber, address, dateOfBirth, age);
                data = streamReader.ReadLine();
            }
        }

        public void SearchTrainee()
        {
            FileStream fileStream = new FileStream(@"C:\Users\Lenovo\Desktop\.net\FreshersTraineeManagement\trainee.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            bool isNotFound = true;
            Console.Write("\nEnter letter to be search: ");
            string input = Console.ReadLine();
            string record = streamReader.ReadLine();

            while (record != null)
            {
                string[] trainees = record.Split("\n");

                foreach (string trainee in trainees)
                {
                    string[] values = trainee.Split(", ");

                    if (record.Contains(input))
                    {
                        Console.WriteLine("\nId: {0}\nName: {1}\nMobile number: {2}\nAddress: {3}\nDate of birth: {4}\n",
                            values[0], values[1], values[2], values[3], values[4]);
                    }
                    record = streamReader.ReadLine();
                }
            }
            if (isNotFound)
            {
                Console.WriteLine("Not Found");
            }
            fileStream.Close();
            streamReader.Close();
        }

    }
}
