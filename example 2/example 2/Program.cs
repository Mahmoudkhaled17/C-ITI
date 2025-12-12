namespace example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddMethod(5, 10);
        }
        public static void AddMethod(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("the sum is"+sum);
        }
    }
}
