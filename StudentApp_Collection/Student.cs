using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Collection
{
    class Student
    {
        public string _name;
        public int _id;
        public string _standard;
        public string _address;

        public Student()
        {
        }
        public int Gid()
        {
            return this._id;
        }
        public string Gname()
        {
            return this._name;
        }
        public string GStandard()
        {
            return this._standard;
        }
        public string GAddress()
        {
            return this._address;
        }
    }
}
