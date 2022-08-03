using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1demo;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            int res1 = obj.sum(8, 9);
            int res2 = obj.sub(21, 9);
            int res3 = obj.mul(79, 9);
            int res4 = obj.modul(89, 9);

            Console.WriteLine("Hello Gl");
            Console.WriteLine("result are of add :"+res1+ " , subtract :"+res2+" , multiply :"+res3+" , modulo is :"+res4);
            Console.ReadLine();
        }
    }
}
