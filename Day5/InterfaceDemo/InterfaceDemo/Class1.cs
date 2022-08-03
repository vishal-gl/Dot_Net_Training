using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class XYZ : Interface1
    {
        public void add()
        {
            Console.WriteLine("I am from XYZ");
            
        }

        public int calc()
        {
            int sum;
            sum = 10;
            return sum;
        }
    }
}
