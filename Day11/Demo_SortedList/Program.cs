using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            //Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");
            sortedList.Add(7, "July");
            sortedList.Add(6, "June");


            //Displaying using fior each
            Console.WriteLine("Displaying using for each");
            foreach(DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " :" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //using for loop
            Console.WriteLine("Displaying using for loop");
            for(int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + " :" + sortedList.GetByIndex(i));
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //index
            Console.WriteLine("Displaying value :");
            Console.WriteLine(sortedList[5].ToString());
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //capacity
            Console.WriteLine("Displaying Count");
            Console.WriteLine(sortedList.Count);
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Remove
            Console.WriteLine("Displaying After removing 1 :");
            sortedList.Remove(1);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " :" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //Contains
            Console.WriteLine("Displaying using of Contains Apr or not : ");
            Console.WriteLine(sortedList.ContainsValue("Apr"));
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //copy to arrayList

            Console.WriteLine("Now we are inside the array list and print Values :");
            ArrayList a = new ArrayList(sortedList.Values);
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
        
          
    }
}
