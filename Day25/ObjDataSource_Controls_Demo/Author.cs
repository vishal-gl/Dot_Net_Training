using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectDatasourceControls_Demo
{
    public class Author
    {
        //Fields
        string firstName;
        string lastName;

        //Constructors
        public Author()
        { }
        public Author(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        

    }
}