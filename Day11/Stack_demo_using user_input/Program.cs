using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_demo_using_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string member;
            int total;
            Console.WriteLine("Enter the Total number in your Family : ");
            total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter the name of Family Member {0} ", i + 1);
                member = Console.ReadLine();
                stack.Push(member);



            }

            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("All Family Members Are Given Below : ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine();




        }
    }
}
