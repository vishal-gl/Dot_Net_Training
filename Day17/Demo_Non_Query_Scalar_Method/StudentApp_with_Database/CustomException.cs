using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_with_Database
{
    
    class MyException : ApplicationException
    {
        public void CustomEx()
        {
            Console.WriteLine("Your Input id Invalid");
            Console.WriteLine("Please Give Valid Input");
        }

    }
}
