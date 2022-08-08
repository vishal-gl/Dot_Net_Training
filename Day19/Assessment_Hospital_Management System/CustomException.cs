using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital_Management_System
{
    
    class CustomException : ApplicationException
    {
        public void CustomEx()
        {
            Console.WriteLine("Your Input id Invalid");
            Console.WriteLine("Please Give Valid Input");
        }

    }
}
