using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_BusinessLogic
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
