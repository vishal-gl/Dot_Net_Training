using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Delegate_Demo
{
    //Anonymous methods can also be passed to a method 
    //that accepts the delegate as a parameter.
    //As shown below --> PrintHelperMethod() takes the first parameter of the Print Delegate

    public delegate void Print(int val);
    class Program
    {
        public static void PrintHelperMEthod(Print printDel,int val)
        {
            val += 10;
            printDel(val);
        }
        static void Main(string[] args)
        {

            PrintHelperMEthod(delegate (int val)
            {
                Console.WriteLine("Anonymous Method : {0}", val);
            }
            , 100);
            Console.ReadLine();
        }
    }
}
