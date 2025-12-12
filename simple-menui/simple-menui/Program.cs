namespace simple_menui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number");
            string firstInput = Console.ReadLine();
            Console.WriteLine("second number");
            string secondInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);
            int secondNumber = int.Parse(secondInput);

            Console.WriteLine("Choose an operation: 1. +\n 2.- \n 3.* \n 4./");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine($"Result: {firstNumber + secondNumber}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {firstNumber - secondNumber}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {firstNumber * secondNumber}");
                    break;
                case "4":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        float divResult = (float)firstNumber / secondNumber;
                        Console.WriteLine($"Result: {divResult}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
    }
}
