using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Assesment_7.Filter
{
    public class CustomException : Exception
    {
        public string message { get; set; }
        public CustomException()
        {

        }
        public CustomException(string msg) : base(msg)
        {
            message = msg;
        }
    }
}