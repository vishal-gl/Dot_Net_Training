using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Example
    {
        int _empid, _eage;
        string _ename, _eaddress;
        public int empid
        {
            set
            {
                _empid = value;
            }
            get
            {
                return _empid;
            }
        }
        public int eage
        {
            set
            {
                _eage = value;
            }
            get
            {
                return _eage;
            }
        }

        public string eaddress
        {
            set
            {
                _eaddress = value;
            }
            get
            {
                return _eaddress;
            }
        }

        public string ename
        {
            set
            {
                _ename = value;
            }
            get
            {
                return _ename;
            }
        }

    }
        class Program
        {

            static void Main(string[] args)
            {
                Example obj1 = new Example();
                obj1.empid = 501;
                obj1.eage = 22;
                obj1.ename = "Vishal";
                obj1.eaddress = "Nagpur";

                Console.WriteLine("Employee details are: ");
                Console.WriteLine("Employee id: " + obj1.empid);
                Console.WriteLine("Employee Name: " + obj1.ename);
                Console.WriteLine("Employee age: " + obj1.eage);
                Console.WriteLine("Employee address: " + obj1.eaddress);
                Console.ReadLine();

            }
        }
}
