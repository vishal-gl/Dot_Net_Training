using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    partial class Employee1
    {
        //Private Members
        string _firstName;
        string _lastName;
        double _salary;
        string _gender;

        //Properties

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value; ;
            }

        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value; ;
            }

        }

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value; ;
            }

        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value; ;
            }

        }
    }
}
