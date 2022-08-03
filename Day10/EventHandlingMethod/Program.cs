using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingMethod
{
    //this is subscribed class
    class Program
    {
        static void Main(string[] args)
        {
            AddtwoNumbers a = new AddtwoNumbers();
            a.ev_OddNumber += new AddtwoNumbers.dg_OddNumber(EventMessage);
            a.ev_OddNumber += new AddtwoNumbers.dg_OddNumber(AlertMessage);
            a.Add();
            Console.Read();

        }
        //delegates call ths method when event raised

        static void EventMessage()
        {
            Console.WriteLine("Event exected : this is odd Number");

        }

        static void AlertMessage()
        {
            Console.WriteLine("This is Alert Message");
        }

    }

    //tghis is pubisher class

    class AddtwoNumbers
    {
        public delegate void dg_OddNumber();
        public event dg_OddNumber ev_OddNumber;

        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            //Check if result is odd number the raise event

            if((result % 2!=0) && (ev_OddNumber != null)){
                ev_OddNumber();
            }
        }

        
    }
}
