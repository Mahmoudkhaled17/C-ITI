using employee;
namespace day6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] menu = { "new", "display", "exit" };
            int choice = 0;
            //Employee employee = new Employee();
            class1 emp = new class1();
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
                            //employee.get();
                            get(emp);

                            Console.Clear();

                        }
                        if (choice == 1)
                        {
                            Console.Clear();

                            //employee.show();
                            display(emp);

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
        public static void get(class1 obj)
        {
            Console.WriteLine("Enter Name:");
            obj.name2 = Console.ReadLine();
            Console.WriteLine("Enter id:");
            obj.id2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            obj.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter age:");
            obj.age2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        public static void display(class1 obj)
        {
            Console.WriteLine("Name: " + obj.name2);
            Console.WriteLine("ID: " + obj.id2);
            Console.WriteLine("Salary: " + obj.Salary);
            Console.WriteLine("Age: " + obj.age2);

        }
    }
}
