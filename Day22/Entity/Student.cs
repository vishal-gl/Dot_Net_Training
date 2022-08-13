using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        string _id;
        string _name;
        byte _age;
        string _standard;
        string _address;
        string _cid;
        static int num = 0;

        public Student()
        {
        }
        public string Gid()
        {
            return this._id;
        }
        public string Gname()
        {
            return this._name;
        }
        public byte GAge()
        {
            return this._age;
        }
        public string GStandard()
        {
            return this._standard;
        }
        public string GAddress()
        {
            return this._address;
        }
        public string GCId()
        {
            return this._cid;
        }
    }
}
