namespace split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter expersion");
            string input = Console.ReadLine();
            string[] parts = input.Split(new char[] { '+', '-', '*', '/' });

            int index = input.IndexOfAny(new[] { '+', '-', '*', '/' });

            Console.WriteLine($"First part: {parts[0]}");
            Console.WriteLine($"Operator: {input[index]}");
            Console.WriteLine($"Second part: {parts[1]}");

           switch(input[index])
            {
                case '+':
                    Console.WriteLine($"Result: {int.Parse(parts[0]) + int.Parse(parts[1])}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {int.Parse(parts[0]) - int.Parse(parts[1])}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {int.Parse(parts[0]) * int.Parse(parts[1])}");
                    break;
                case '/':
                    Console.WriteLine($"Result: {int.Parse(parts[0]) / int.Parse(parts[1])}");
                    break;
                default:
                    Console.WriteLine("Unknown operator");
                    break;
            }
        }
    }
}
