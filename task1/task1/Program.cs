namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of " + n + " is: " + factorial(n));
        }

        public static int factorial(int n)
        {
            int result = 1;
            if (n <= 1)
              return 1;
             result = n * factorial(n - 1);
            return result;
        }
    }
}
