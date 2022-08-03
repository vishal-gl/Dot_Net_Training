using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stacks_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push("Shardha");
            s.Push("David");
            s.Push("Jmes");
            s.Push(4);
            s.Push("Nandini");
            s.Push("Santosh");
            s.Push("Global Logic");



            //Displaying
            foreach(var a in s)
                //it also print from last push to first push
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Peek MEthod
            Console.WriteLine(s.Peek());//shows last element we push
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Sequencing Of Removing
            Console.WriteLine("Sequencing of removing Elements from stack");
            Console.WriteLine();
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();





            Console.ReadLine();

        }
    }
}
