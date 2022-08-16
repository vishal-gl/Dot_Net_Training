using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    class Validation:ApplicationException
    {
        public void Input()
        {
            Console.WriteLine("Please Enter a Valid Output");
            Console.WriteLine();
        }
        public void Constraints()
        {
            Console.WriteLine("Please! Fill Only Those CID which are given in the List");

        }
    }
}
