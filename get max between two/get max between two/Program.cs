namespace get_max_between_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("second number");
            string input2 = Console.ReadLine();
            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            if (number1 > number2)
            {
                Console.WriteLine("The maximum number is: " + number1);
            }
            else
            {
                Console.WriteLine("The maximum number is: " + number2);
            }
        }
    }
}
