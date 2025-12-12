namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "new", "display", "exit" };
            int choice = 0;
            string name="" ;
            string id="" ;
            string salary="" ;
            bool loop = true;
            do { 
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

                            getvalues(out name ,out id ,out salary);
                  
                            Console.Clear();
                        }
                            if (choice == 1)
                            {
                            Console.Clear();

                            showvalues(name , id ,salary);

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
        static public void getvalues(out string name ,out string id ,out string salary) {
            Console.WriteLine("enter your name:");
            name =Console.ReadLine();
            Console.WriteLine("enter your id:");
            id=Console.ReadLine();
            Console.WriteLine("enter your salary:");
            salary = Console.ReadLine();

        }

        static public void showvalues(string name, string id, string salary)
        {
            Console.WriteLine("your name is :" + name);
            Console.WriteLine("your id is :" + id);
            Console.WriteLine("your salary is :" + salary);
        }



        }
}
