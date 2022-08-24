using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelDemo.Models
{
    public class Address
    {
        public int AddressId
        {
            get;set;
        }
        public string Country
        {
            get;set;
        }
        public string State
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string Pincode
        {
            get; set;
        }
    }
}