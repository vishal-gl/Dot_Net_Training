using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Student_Course_Data_Access_Layer
{
    interface IStudent
    {
        void AddStudent(string Id, string Name, int Age, string Standard, string City, string CId);
        void Update(byte n, string id, string m);
        
        void DisplayAll();
        bool DeleteStudent(string id);

        void ReadCourse();

    }
}
