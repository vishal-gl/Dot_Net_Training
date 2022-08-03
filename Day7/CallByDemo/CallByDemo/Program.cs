using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByDemo
{
    class Program
    {
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Previous value of integer i: " + i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("Current value of integer i : " + i.ToString());
            Console.ReadLine();
        }
    }
}
