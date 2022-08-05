using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_Custom_Handling
{
    class CustomException:ApplicationException
    {
        public void CheckBankCustomEx()
        {
            Console.WriteLine("Your Balance is less than 500");
            Console.WriteLine("Please! You can't withdraw your money");
            Console.WriteLine("Thank you for using us!");
        }
    }
}
