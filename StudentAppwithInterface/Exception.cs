using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppwithInterface
{
    
    #region Custom Exception
    class MyException : ApplicationException
    {

        public void MyWrongException()
        {
            Console.WriteLine("Exception occured, Choice should not be above mentioned options");

            Console.WriteLine();
            Console.WriteLine("Please Select Valid Option !!! ");
            Console.WriteLine();
        }

    }

    #endregion

}
