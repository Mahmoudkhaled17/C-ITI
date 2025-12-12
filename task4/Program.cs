namespace day7
{
    public class employee
    {
        public string name;
        private static int counter;
        public int Id
        {
            get;
            private set;

        }

        public int age;
        private double salary;
        public string gender;

        public employee() : this("No Name", 0, 0, "Male")
        {
            counter++;
            Id = counter;

        }
        static employee()
        {
            counter = 0;
        }

        public employee(string name, int age, double Salary, string gender)
        {
            this.name = name;
            this.age = age;
            this.Salary = salary;
            this.gender = gender;
        }




        public double Salary
        {
            get { return salary; }

            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative. Setting salary to 0.");
                    salary = 0;
                }
            }
        }





    }

    internal class Programك
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[3]
            {
                new employee(), new employee(), new employee()
            };

            string[] menu = { "new", "display", "search", "static" };
            int choice = 0;

            bool loop = true;
            do
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == choice)
                        Console.BackgroundColor = ConsoleColor.Blue;
                    else
                        Console.ResetColor();

                    Console.SetCursorPosition(120 / 2, (30 / 4) * (i + 1));
                    Console.WriteLine(menu[i]);
                }
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        choice--;
                        if (choice < 0)
                            choice = menu.Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        choice++;
                        if (choice >= menu.Length)
                            choice = 0;
                        break;
                    case ConsoleKey.Enter:

                        if (choice == 0)
                        {
                            Console.Clear();
                            getvalues(employees);
                            Console.Clear();
                        }
                        if (choice == 1)
                        {
                            Console.Clear();
                            employees.displayemployee();

                            Console.ReadKey();
                            Console.Clear();



                        }
                        if (choice == 2)
                        {
                            Console.Clear();
                            search(employees);

                            Console.ReadKey();
                            Console.Clear();

                        }
                        if (choice == 3)
                        {
                            Console.ResetColor();
                            Console.Clear();



                            static_m(employees);

                            Console.ReadKey();
                            Console.Clear();



                        }
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        loop = false;
                        break;

                }
            } while (loop);





        }
        public static void getvalues(employee[] employee)
        {
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("enter employee {0} name:", i + 1);
                employee[i].name = Console.ReadLine();
                Console.WriteLine("enter employee {0} salary:", i + 1);
                employee[i].Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee {0} gender:", i + 1);
                employee[i].gender = Console.ReadLine();
                Console.WriteLine("Enter employee {0} age:", i + 1);
                employee[i].age = int.Parse(Console.ReadLine());

            }
        }
        public static void search(employee[] employee)
        {
            //employee[] rec = new employee[3];
            Console.WriteLine("enter employee name to search:");
            string searchname = Console.ReadLine();

            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].name == searchname)
                {
                    Console.WriteLine("employee found:");
                    Console.WriteLine("Name: {0}", employee[i].name);
                    Console.WriteLine("ID: {0}", employee[i].Id);
                    Console.WriteLine("Salary: {0}", employee[i].Salary);
                    Console.WriteLine("gender: {0}", employee[i].gender);
                }
                else
                {
                    Console.WriteLine("employee not found");
                }
            }
        }

        public static void static_m(employee[] emp)
        {
            double sum = 0;
            double max = emp[0].Salary;
            for (int i = 0; i < emp.Length; i++)
            {
                sum += emp[i].Salary;


                if (emp[i].Salary > max)
                {
                    max = emp[i].Salary;
                }
                ;
            }
            Console.WriteLine("sum of Salary: {0}", sum);
            Console.WriteLine("max Salary: {0}", max);
        }

        



    }
    public static class employee_exten
    {
        public static void displayemployee(this employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("employee {0} name: {1}", i + 1, employees[i].name);
                Console.WriteLine("employee {0} salary: {1}", i + 1, employees[i].Salary);
                Console.WriteLine("employee {0} ID: {1}", i + 1, employees[i].Id);
                Console.WriteLine("employee {0} gender: {1}", i + 1, employees[i].gender);
            }


        }
    }
}
