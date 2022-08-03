using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_function_Demo
{
    //the anonymous methods reduce the complexity of code
    //espescilly where there are several events defined
    /// <summary>
    /// with the anonymous method ,the code does not perform faster
    /// the compiler still defines methods implicitly
    /// </summary>
    /// 
    delegate void operation();
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate Instantiation
            //define
            operation obj = delegate
             { Console.WriteLine("I am anonymous method ");
 
             };
            obj();
            Console.ReadLine();

        }
    }
}
