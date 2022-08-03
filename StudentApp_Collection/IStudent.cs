using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Collection
{
    

    internal interface IStudent
    {
        bool Add(ref List<Student> st, ref int num);
        bool disp(ref List<Student> st);
        bool delete(ref List<Student> st);
        bool findV(ref List<Student> st);
        bool updated(ref List<Student> st);

        void DisplayMenu();
    }
}
   
   
    
    

