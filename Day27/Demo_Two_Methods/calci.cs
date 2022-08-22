using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Two_Methods
{
    class calci
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
            calci p = new calci();
            int a = 9, b = 6;
            int res1 = p.Add(a, b);
            int res2 = p.Sub(a, b);
            Console.WriteLine(res1 + res2);
            Console.ReadKey();
        }
    }
}
