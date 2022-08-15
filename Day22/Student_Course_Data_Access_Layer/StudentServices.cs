using System;

namespace Student_Course_Data_Access_Layer
{
    public class StudentServices : IStudent
    {

        Sql_Connection std = new Sql_Connection();
        
        public void AddStudent(string Id, string Name, int Age, string standard, string city, string cid)
        {
            if (std.Insertdata(Id, Name, Age, standard, city, cid))
            {
                Console.WriteLine("Student Details Added Successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed To Add Student Details");
                Console.WriteLine();
            }
        }

        

        public bool DeleteStudent(string id)
        {
            if (std.GetNumberOfRecords() > 0)
            {
                if (std.DeleteData(id))
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool CheckId(string Id)
        {

            if (std.CheckId(Id))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input Id is not available in Record");
                return false;

            }
            

        }

        public void DisplayAll()
        {
            if (std.GetNumberOfRecords() != 0)
            {
                Console.WriteLine("All Students Details Are Shown Below:");
                std.ReadData();
            }

            else
            {
                Console.WriteLine("No Data Found, First Add Some Students");
            }
        }

        

        public void Update(byte n,string id,string m)
        {
            if (std.Update(n,id,m))
            {
                Console.WriteLine("Student Details Updated Successfully!");
            }
            else
            {
                Console.WriteLine("\nStudent Not Found");
            }

        }

        public void ReadCourse()
        {
            std.ReadCourse();
        }
        


        

        
    }
}
