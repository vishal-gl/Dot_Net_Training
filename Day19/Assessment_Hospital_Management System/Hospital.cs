using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital_Management_System
{
    class Hospital
    {
        public string _name;
        public int _age;
        public string _address;
        public string _disease;
        public string _doctorIncharge;
        public string _roomNo;

        public Hospital()
        {

        }
        public string Gname()
        {
            return this._name;
        }
        public int GAge()
        {
            return this._age;
        }
        public string GDisease()
        {
            return this._disease;
        }
        public string GAddress()
        {
            return this._address;
        }
        public string GDoctorIncharge()
        {
            return this._doctorIncharge;
        }
        public string GRoomNo()
        {
            return this._roomNo;
        }
    }
}
