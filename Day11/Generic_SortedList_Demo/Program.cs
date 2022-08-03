using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_SortedList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Craeting
            SortedList<string, string> list = new SortedList<string,string>();
            //
            list.Add("Vishal", "USA");
            list.Add("Ayush", "Haryana");
            list.Add("Charles", "London" );
            list.Add("NArendra", "India");

            //Displaying
            foreach(var a in list)
            {
                Console.WriteLine(a.Key + " is from " + a.Value);

            }

            //Adding using Index
            list["Shardha"] = "Germany";

            //Count
            Console.WriteLine(list.Count);


            //Index

            Console.WriteLine(list["Vishal"]);

            //try vAlue

            list.TryGetValue("Shardha", out string number);
            Console.WriteLine(number);

            //contains
            Console.WriteLine(list.ContainsValue("USA"));
            Console.ReadLine();
            
        }
    }
}
