using System;

namespace Demo_Two_methods
{
    public class Program
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 9;
            int b = 7;
            int res1 = p.Add(a, b);
            int res2 = p.Sub(a,b);
            Console.WriteLine("Hello World!");
        }
    }
}
