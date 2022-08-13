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
            Console.WriteLine("Enter a Valid Output");
        }

    }
}
