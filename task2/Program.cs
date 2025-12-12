namespace task2
{
    public class stack
    {
        public int top;
        public int maxsize;
        public int[] stackarray;

        public stack(int size)
        {
            maxsize = size;
            top = 0;
            stackarray = new int[maxsize];
        }
        public void push(int element)
        {
            if (top == maxsize)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                stackarray[top] = element;
                top++;
            }
        }
        public int pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                top--;
                return stackarray[top];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack(5);
                s.push(10);
                s.push(20);
                s.push(30);
                s.push(40);
                s.push(50);
            s.push(60); 
                Console.WriteLine(s.pop());
                Console.WriteLine(s.pop());
                Console.WriteLine(s.pop());
                Console.WriteLine(s.pop());
        }
    }
}
