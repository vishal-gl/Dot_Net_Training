using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEneric_Stack_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Vishal");
            s.Push("Anmol");
            s.Push("Saniya");
            s.Push("Mohit");
            // Displaying

            foreach(var a in s)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            //peek
            Console.WriteLine("The top element of the stack is : " + s.Peek());

            //pop 
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine("After popping the elemnts, List is : ");
            foreach (var a in s)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            //reverse
            s.Reverse();
            Console.WriteLine("After the Reversing :");
            foreach (var a in s)
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
