using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate_demo
{
    public delegate void MultiCastDelegate(int a, int b);
    class Program
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Sum is : "+(x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Diffrence is : "+(x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Product is : "+(x * y));
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine("Quotient is is : "+(x / y));
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            MultiCastDelegate objd = new MultiCastDelegate(obj1.Mul);

            objd += obj1.Add;
            objd += obj1.Sub;
            objd += obj1.Divide;
            objd(40, 50);
            //objd.GetInvocationList();
            objd -= obj1.Add;
            //objd -= obj1.Divide;
            //objd.GetInvocationList();
            objd(20, 30);
            foreach(MultiCastDelegate dele in objd.GetInvocationList())
            {
                try
                {
                    dele.Invoke(40,0);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(dele.Method.Name + ex.Message);
                }
                
            }
            Console.ReadLine();

        }
    }
}
