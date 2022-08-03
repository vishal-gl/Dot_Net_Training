using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_value_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 30;
            int p = 0;
            int q = 0;
            calc(a, b, out p, out q);
            Console.WriteLine("Divisor is {0} remainder is :{1}", p, q);
            Console.ReadLine();
        }
        static  void calc(int x,int y,out int divider,out int remainder)
        {
            divider = x / y;
            remainder = x % y;
        }
    }
}
