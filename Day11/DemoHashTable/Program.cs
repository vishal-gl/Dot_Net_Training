using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            //Adding
            h.Add("Microsoft", "USA");
            h.Add("Sony", "Japan");
            h.Add("IKEA", "Sweden");
            h.Add("India", "TATA");
            h.Add("Mercedes", "Germany");
            h.Add(1, "Vishal");
                //Display
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + ":" + item.Value);

            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            // Capacity
            Console.WriteLine("Count is : " + h.Count);
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Remove
            //Console.WriteLine("-----------------------");
            Console.WriteLine("After Removing");
            h.Remove("IKEA");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + ":" + item.Value);

            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Contains
           // Console.WriteLine("------------------------");
            Console.WriteLine("Contains Conditions ");
            if (h.ContainsValue("Germany"))
            {
                Console.WriteLine("Yes it is there");
            }
            else
            {
                Console.WriteLine("no it is not there");
            }
            if (h.ContainsKey("Sweden"))
            {
                Console.WriteLine("Yes it is there");
            }
            else
            {
                Console.WriteLine("no it is not there");
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            // cpopies value in arraylist
           // Console.WriteLine("-----------------");
            Console.WriteLine("After Copying");

            ArrayList a = new ArrayList(h.Values);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.ReadLine();




        }
    }
}
