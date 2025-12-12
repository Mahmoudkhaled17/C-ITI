namespace day7
{
    public class employee
    {
        public string name;
        public int id;
        public int age;
        private double salary;
        public string gender;

        public employee() : this("No Name", 0, 0, 0, "Male")
        {

        }

        public employee(string name, int id, int age, double Salary, string gender)
        {
            this.name = name;
            this.id = id;
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

    internal class Program
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
                            display(employees);

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
                Console.WriteLine("enter employee {0} id:", i + 1);
                employee[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter employee {0} salary:", i + 1);
                employee[i].Salary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee {0} gender:", i + 1);
                employee[i].gender = Console.ReadLine();
                Console.WriteLine("Enter employee {0} age:", i + 1);
                employee[i].age = int.Parse(Console.ReadLine());

            }
        }
        public static void display(employee[] employee)
        {
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("employee {0} name: {1}", i + 1, employee[i].name);
                Console.WriteLine("employee {0} id: {1}", i + 1, employee[i].id);
                Console.WriteLine("employee {0} salary: {1}", i + 1, employee[i].Salary);
                Console.WriteLine("employee {0} gender: {1}", i + 1, employee[i].gender);
                Console.WriteLine("employee {0} age: {1}", i + 1, employee[i].age);
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
                    Console.WriteLine("ID: {0}", employee[i].id);
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
                Console.WriteLine("sum of Salary: {0}", sum);

                if (emp[i].Salary > max)
                {
                    max = emp[i].Salary;
                }
                Console.WriteLine("max Salary: {0}", max);



            }
        }
    }
}
