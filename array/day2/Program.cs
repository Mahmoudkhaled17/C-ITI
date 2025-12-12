using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int x;
            ////for (x = 0; x < 10; ++x)
            ////{
            ////    System.Console.WriteLine(x);
            ////}
            ////Console.WriteLine("Final value of x: " + x);
            ////int y;
            ////for (y = 0; y < 10; y++)
            ////{
            ////    System.Console.WriteLine(y);
            ////}
            ////Console.WriteLine("Final value of x: " + y);

      


            //array max,min

            Console.WriteLine("number of array element");
            string number=Console.ReadLine();
            int num=int.Parse(number);

            int[] arr = new int[num];

            Console.WriteLine("enter the values");
            for (int i = 0; i < arr.Length; i++)
            {
                string x=Console.ReadLine();

                arr[i]=int.Parse(x);
            }



            int sum = 0;
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }



            }
            float avg = sum / num;
            Console.WriteLine("the avg is {0}", avg);
            Console.WriteLine("the sum is {0}",sum);
            Console.WriteLine("the max is {0}", max);
            Console.WriteLine("the min is {0}", min);


        }
    }
}
