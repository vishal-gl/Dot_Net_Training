using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NonGeneric_arrayList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Vishal");
            array.Add("James");
            array.Add("Nishant");
            array.Add("Shrushti");
            array.Add(18);
            Console.WriteLine("At First : ");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("Before Insertion");
            Console.WriteLine("Count is " + array.Count);
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            array.Insert(2, "Tim");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("After Insertion");
            Console.WriteLine("Count is " + array.Count);

            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //Index
            Console.WriteLine("-------------");
            Console.WriteLine("Index :");
            Console.WriteLine(array[5].ToString());
            Console.WriteLine("-------------");

            // REMOVE
            

            array.RemoveAt(3);//Shrushti is deleted
            array.Remove("Vishal");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("After Deletion");
            Console.WriteLine("Count is " + array.Count);
            Console.WriteLine("-------------");

            //Sort
            array.Sort();
            Console.WriteLine("--After Sorting----");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");

            //Reverse
            array.Reverse();
            Console.WriteLine("----After reversing---------");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");

            // Remove Range

            array.RemoveRange(1, 2);
            foreach (var item in array)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");

            //Contains
            Console.WriteLine("----------------------");
            Console.WriteLine("After Asking if Contains");
            Console.WriteLine(array.Contains("James"));
            Console.WriteLine("----------------------");
            // Get Range
            Console.WriteLine("----------------------");
            ArrayList names = new ArrayList();
            names = array.GetRange(0, 3);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //names.Clear();
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}





            Console.ReadLine();
        }
    }
}
