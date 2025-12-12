namespace employee
{
    public enum Gender
    {
        Male, Female
    }
    public class Employee
    {
        public string name;
        public int id;
        public double salary;
        public int age;
        public Gender gender;

        public Employee()
        {
            name = "unknown";
            id = 0;
            salary = 0.0;
            age = 0;
            gender = Gender.Male;
        }


        public void get()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("write the gender");
            string genderInput = Console.ReadLine();
            if (genderInput == "m")
            {
                gender = Gender.Male;
            }
            else if (genderInput == "f")
            {
                gender = Gender.Female;
            }
        }
        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("gender: " + gender);
        }
    }


    public class class1
    {
        public string name2;
        public int id2;
        public double salary2;
        public int age2;

        public double Salary
        {
            get { return salary2; }
            set
            {
                if (value < 0)
                {
                    salary2 = 0;
                }
                else
                {
                    salary2 = value;
                }
            }
        }
    }
}
