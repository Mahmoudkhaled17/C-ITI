namespace operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            Console.WriteLine("Addition: " + Add(a, b));
            Console.WriteLine("Subtraction: " + Subtract(a, b));
            Console.WriteLine("Multiplication: " + Multiply(a, b));
            Console.WriteLine("Division: " + Divide(a, b));

          int sum1, diff1, mult1;
            float div1;

            allOperation(a, b, out  sum1, out  diff1, out  mult1, out  div1);
            Console.WriteLine("All Operations:");
            Console.WriteLine("Addition: " + sum1);
            Console.WriteLine("Subtraction: " + diff1);
            Console.WriteLine("Multiplication: " + mult1);
            Console.WriteLine("Division: " + div1);



        }

        static public int Add(int a, int b)
        {
            return a + b;
        }
        static public int Subtract(int a, int b)
        {
            return a - b;
        }
        static public int Multiply(int a, int b)
        {
            return a * b;
        }
        static public int Divide(int a, int b)
        {
            return a / b;
        }

        static public void allOperation(int a, int b, out int sum, out int diff, out int mult, out float div)
        {
            sum = Add(a, b);
            diff = Subtract(a, b);
            mult = Multiply(a, b);
            div = Divide(a, b);
        }

    }
}
