using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Craeting and Intialising 
            List<string> l = new List<string>
            {
                "Australia",
                "Belgium",
                "Brazil"
            };
            l.Add("India");
            l.Add("England");
            l.Add("Hungary");
            l.Add("China");
            l.Add("Germany");
            l.Add("Egypt");

            //displaying
            foreach (var a in l)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=============================");
            l[3] = "South Africa";
            Console.WriteLine(l[3]);
            foreach (var a in l)
            {
                Console.WriteLine(a);
            }

            //Capacity
            Console.WriteLine("Count is : " + l.Count);

            //Sorting
            l.Sort();
            Console.WriteLine("after Sorting is : ");
            foreach (var a in l)
            {
                Console.WriteLine(a);
            }

            //Reversing
            Console.WriteLine("=============================");
            Console.WriteLine("After Reversing is :");
            l.Reverse();
            foreach (var a in l)
            {
                Console.WriteLine(a);
            }

            //Removing
            Console.WriteLine("=============================");
            Console.WriteLine("After removing is: ");
            l.Remove("Germany");
            l.RemoveAt(0);
            foreach (var a in l)
            {
                Console.WriteLine(a);
            }

            ////Remove All
            ///l.Claer();
            ///

            //contain
            Console.WriteLine("=============================");
            Console.WriteLine(l.Contains("Egypt"));
            Console.WriteLine("=============================");

            //GEt RAnge
            List<string> secondList = new List<string>();
            secondList = l.GetRange(0, 3);
            foreach (var a in secondList)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();





        }
    }
}
