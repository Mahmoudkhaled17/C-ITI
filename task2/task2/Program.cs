namespace task2
{
    struct complex
    {
        public double real;
        public double imag;
        public complex(double r, double i)
        {
            real = r;
            imag = i;
        }
        public complex add(complex x)
        {
            return new complex(this.real + x.real, this.imag + x.imag);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the first comlex");
            string input=Console.ReadLine();
            string[] parts1=input.Split(new char[]{'+','i' });
            complex a = new complex(double.Parse(parts1[0]), double.Parse(parts1[1]));

            Console.WriteLine("input the second comlex");
             input = Console.ReadLine();
            string[] parts2 = input.Split(new char[] { '+', 'i' });
            complex b = new complex(double.Parse(parts2[0]), double.Parse(parts2[1]));

            complex c = a.add(b);
            complex d = addmethod(a, b);
            Console.WriteLine("c = {0} + {1}i", c.real, c.imag);
            Console.WriteLine("c = {0} + {1}i", d.real, d.imag);
        }

        public static complex addmethod(complex a, complex b)
        {
            return new complex(a.real + b.real, a.imag + b.imag);
        }
    }
}
