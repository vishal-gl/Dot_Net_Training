using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    static class Program
    {
        //Instance Method
        public static int InstCalculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        public static string Name;
        public static string FirstName;
        static Program()
        {
            Name = "Global Logic Training";
            FirstName = "Vishal";

        }
        public static int Calculation(int x,int y)
        {
            int val = x * y;
            return val;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(InstCalculation(12, 12));
            Console.WriteLine(Name);
          
            Console.ReadKey();

        }
    }
}
