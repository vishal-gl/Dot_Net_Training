using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyanmic_keyword
{
    public class author
    {
        dynamic name;
        dynamic NameProperty
        {
            get;
            set;
        }
        public dynamic fullNameMethod(dynamic d)
        {
            name = "Mahesh";
            dynamic firstname = name;
            return firstname + " " + d;
        }

    }
    class Program
    {
       
        
            static void myDynamicMethod(dynamic dynamicparam)
            {
                dynamic lastname = "Kumar";
                dynamic dynAuthor = new author();
                Console.WriteLine(dynAuthor.fullNameMethod(lastname));
                Console.ReadKey();
            }
        static void Main(string[] args)
        {
            myDynamicMethod("dynamicValue");

        }
    }
}
