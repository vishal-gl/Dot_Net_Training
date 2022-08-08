using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital_Management_System
{
    interface IHospital
    {
        bool Add(ref List<Hospital> H, ref int num);
        bool Disp(ref List<Hospital> H);
        bool delete(ref List<Hospital> H);
        
        bool updated(ref List<Hospital> H);

        void DisplayMenu();
    }
}
