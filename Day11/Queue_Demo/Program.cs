using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Vishal");
            q.Enqueue("Sanal");
            q.Enqueue("Vidya");
            //Displaying Queue
            foreach( var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //Conatins

            Console.WriteLine(q.Contains("Sanal"));
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //Count
            Console.WriteLine(q.Count);
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //peek
            Console.WriteLine(q.Peek());
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //sync
            Console.WriteLine();


            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.ReadLine();



        }
    }
}
