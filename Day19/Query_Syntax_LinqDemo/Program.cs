using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_Syntax_LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data DSource
            List<int> integerList = new List<int>()
            {
                1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10
            };
            //Linq Quert using Query Syntax
            var QuerySyntax = from obj in integerList where obj > 2 select obj;

            //Execution
            foreach(var item in QuerySyntax)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
               

            //Linq query using Method Syntax
            var MethodSyntax = integerList.Where(obj => obj > 6).ToList();
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
        }
    }
}
