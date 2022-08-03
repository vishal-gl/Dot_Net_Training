using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Myclass
    {
        public Nullable<int> i;
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Nullable<int> z;
            int? a = null;
            //a=b if a is not null,b=0 if a is null

            int b = a ?? 0;
            Console.WriteLine("y= {0}", b);

            
            
            if (a.HasValue)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("valus is empty");
            }
            
            Myclass c1 = new Myclass();
            if (c1.i == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(c1.i.Value);
            }

            
            Console.ReadLine();

        }
    }
}
