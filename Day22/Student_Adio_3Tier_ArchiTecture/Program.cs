using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Course_BusinessLogic;

namespace Student_Course_Presentation

{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagementIO student = new StudentManagementIO();
            bool flag = true;
            while (flag)
            {
                switch (student.Menu())
                {
                    case 1:
                        student.AddStudent();
                        break;

                    case 2:
                        student.DisplayAll();
                        break;

                    case 3:
                        student.Update();
                        student.DisplayAll();
                        break;

                    case 4:
                        student.DeleteStudent();
                        student.DisplayAll();
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
