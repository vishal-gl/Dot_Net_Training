using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //params meethod
            //ParamsMethod(1, 2, 3, 4, 5, 6,7);
            ParamsMethod(1,2,"nandini","mrunali","shrutho",10.6);

        }
        //public static void ParamsMethod(params int[] arr)

        public static void ParamsMethod(params object[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + (i < arr.Length - 1 ? ", " : ""));

            }
            Console.WriteLine();
            Console.WriteLine("\n Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
