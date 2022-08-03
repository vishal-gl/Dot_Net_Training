using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class ContactInfo
    {



        string _address;
        string _city;
        string _state;
        string _country;
        string _phoneNo;
        string _emailId;

        public ContactInfo()
        {

        }

        ContactInfo(string address, string city, string state, string country, string phoneNo, string emailId)
        {
            this._address = address;
            this._city = city;
            this._state = state;
            this._country = country;
            this._phoneNo = phoneNo;
            this._emailId = emailId;
            Console.ReadLine();


        }
        public string GetAddress()
        {
            return _address;


        }
        public string GetCity()
        {
            return _city;
        }
        public string GetState()
        {
            return _state;
        }
        public string GetCountry()
        {
            return _country;
        }
        public string GetPhoneNo()
        {
            return _phoneNo;
        }
        public string GetEmailId()
        {
            return _emailId;
        }
        public void createContact(string address, string city, string state, string country, string phoneNo, string emailId)
        {
            ContactInfo p = new ContactInfo(address,city,state,country,phoneNo,emailId);
            Console.ReadLine();


        }



        public void displayContact()
        {
            Console.WriteLine("Detail are :");
            Console.WriteLine("Address is : " + GetAddress());
            Console.WriteLine("City is : " + GetCity());
            Console.WriteLine("State  is : " + GetState());
            Console.WriteLine("Country is : " + GetCountry());
            Console.WriteLine("Phone No is : " + GetPhoneNo());
            Console.WriteLine("Email Id is : " + GetEmailId());
            Console.ReadLine();


        }

        static void Main(string[] args)
        {
            ContactInfo p1 = new ContactInfo("MG Colony", "Delhi", "Madhya Pradesh", "India", "91313xxxxx", "vishalabc@gmail.com");
            //ContactInfo p2 = new ContactInfo();
            //p1.createContact("MG Colony","Delhi","Madhya Pradesh","India","91313xxxxx","vishalabc@gmail.com");
            p1.displayContact();
            Console.ReadLine();
        }

    }

    

}