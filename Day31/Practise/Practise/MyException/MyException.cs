using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practise.MyException
{
    public class MyException1:Exception
    {
        public string msg1 { get; set; }
        public MyException1()
        {

        }
        public MyException1(string msg):base(msg)
        {
            msg1 = msg;
        }
    }

}