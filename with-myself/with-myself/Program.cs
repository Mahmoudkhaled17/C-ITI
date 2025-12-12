namespace with_myself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value ? ");
            string x=Console.ReadLine();
            Console.WriteLine("The Value is : " + x);
            string y = (x == "10") ? "ten" : "not ten";
            Console.WriteLine("The Value in words is : " + y);
            int[]arr={1,2,3,4,5};

            Console.WriteLine("Enter the size of array ?");
            int num=int.Parse(Console.ReadLine());
            int[]arr2=new int[num];
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("Enter the value for index "+i);
                arr2[i]=int.Parse(Console.ReadLine());
            }

            for(int i=0;i<num;i++)
            {
                Console.Write(arr2[i]+" ");
            }

            Console.WriteLine("\n enter the array2");
            string nn=Console.ReadLine();
            string[]arr3=nn.Split(',');
            foreach(string s in arr3)
            {
                Console.WriteLine(s);
            }

           

        }
    }
}
