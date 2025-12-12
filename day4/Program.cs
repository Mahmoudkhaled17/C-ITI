using System.Reflection;

namespace day4
{
    enum G
    {
        male, female
    }
    struct Employee
    {
        public string name;
        public string id;
        public string salary;
        public G gender;

        public Employee(string name2, string id2, string salary2, G gender2)
        {
            name = name2;
            id = id2;
            salary = salary2;
            gender = gender2;
        }


        public void get()
        {
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("enter your id:");
            id = Console.ReadLine();
            Console.WriteLine("enter your salary:");
            salary = Console.ReadLine();
            Console.WriteLine("enter your gender:");
            string mm = Console.ReadLine();
            if (mm == "m")
            {
                gender = G.male;

            }
            else
            {
                gender = G.female;

            }
        }

        public void show()
        {
            Console.WriteLine("your name is :" + name);
            Console.WriteLine("your id is :" + id);
            Console.WriteLine("your salary is :" + salary);
            Console.WriteLine("your gender is: " + gender);
        }
    }

    internal class Program
        {

            static void Main(string[] args)
            {

                string[] menu = { "new", "display", "exit" };
                int choice = 0;
                Employee[] emp = new Employee[3];
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
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    Console.WriteLine("enter employee {0} data:", i + 1);
                                    emp[i].get();

                                    //getvalues(out emp[i].name, out emp[i].id, out emp[i].salary, out emp[i].gender);
                                }

                                Console.Clear();
                            }
                            if (choice == 1)
                            {
                                Console.Clear();
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    Console.WriteLine("employee {0} data:", i + 1);
                                    emp[i].show();

                                    //showvalues(emp[i].name, emp[i].id, emp[i].salary, emp[i].gender);
                                }

                                Console.ReadKey();
                                Console.Clear();



                            }
                            if (choice == 2)
                            {
                                Console.Clear();
                                loop = false;
                                break;

                            }
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            loop = false;
                            break;

                    }
                } while (loop);

            }

            //static public void getvalues(out string name, out string id, out string salary, out G gender)
            //{
            //    Console.WriteLine("enter your name:");
            //    name = Console.ReadLine();
            //    Console.WriteLine("enter your id:");
            //    id = Console.ReadLine();
            //    Console.WriteLine("enter your salary:");
            //    salary = Console.ReadLine();
            //    Console.WriteLine("enter your gender:");
            //    string mm = Console.ReadLine();
            //    if (mm == "m")
            //    {
            //        gender = G.male;
            //    }
            //    else
            //    {
            //        gender = G.female;
            //    }

            //}


            //static public void showvalues(string name, string id, string salary, G gender)
            //{
            //    Console.WriteLine("your name is :" + name);
            //    Console.WriteLine("your id is :" + id);
            //    Console.WriteLine("your salary is :" + salary);
            //    Console.WriteLine("your gender is :" + gender);

            //}



        }
    }

