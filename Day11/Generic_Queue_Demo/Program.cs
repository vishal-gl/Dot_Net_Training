using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queue_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            //Adding Elemnts
            q.Enqueue("India");
            q.Enqueue("West Indies");
            q.Enqueue("PAkistan");
            q.Enqueue("Afghanistan");
            q.Enqueue("Sri LAnka");
            q.Enqueue("Nepal");

            //Displaying ELemnts
            foreach(var a in q)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();


            //peek Elemnts
            Console.WriteLine("At the top of queue is  " + q.Peek());
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();


            //capaciy
            Console.WriteLine("Count is : " + q.Count);
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();



            //Dequeue
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("After removing two elements , queue is : ");
            foreach (var a in q)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Reverse
            q.Reverse();
            Console.WriteLine("After the Reversing :");
            foreach (var a in q)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.ReadLine();



        }
    }
}
