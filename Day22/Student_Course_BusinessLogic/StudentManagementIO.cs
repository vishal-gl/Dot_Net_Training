using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Course_Data_Access_Layer;

namespace Student_Course_BusinessLogic
{
    public class StudentManagementIO
    {
        StudentServices studentservice = new StudentServices();
        public byte Menu()
        {
            Console.WriteLine("Press 1 to Add Student");
            Console.WriteLine("Press 2 to View All Students");
            Console.WriteLine("Press 3 to Update Deatils Student");
            Console.WriteLine("Press 4 to Delete Record of Student");
            Console.WriteLine("Press 5 to Exit");
            Console.WriteLine("Enter Your choice:");
            try
            {
                byte option = Convert.ToByte(Console.ReadLine());
                if (option>5)
                {
                    throw new Validation();
                }
                return option;
            }
            catch (Validation V)
            {
                V.Input();
                return Menu();
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);
                return Menu();
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                int age = Convert.ToByte(Console.ReadLine());
                if (age > 125)
                {
                    throw new Validation();
                }
                Console.WriteLine("Enter Class:");
                string standard = Console.ReadLine();
                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();
                
                Console.WriteLine();
                Console.WriteLine("This is List of Courses which we Offered : ");
                
                studentservice.ReadCourse();
                Console.WriteLine();

                Console.WriteLine("Please Enter The CId");
                string cid = Console.ReadLine();
                studentservice.AddStudent(id,name, age, standard, city, cid);

                Console.WriteLine();
            }
            catch (Validation v )
            {
                v.Input();
                Console.WriteLine("Age Should Be less than 125 ");
                Console.WriteLine();
                
                Menu();
            }
            
            

        }

        public void DisplayAll()
        {
            Console.WriteLine();
            studentservice.DisplayAll();
            Console.WriteLine();
        }

        public void Update()
        {
            Console.WriteLine("Enter the Id of Student whose you want to Update Information : ");
            string Id = Console.ReadLine();
            if (studentservice.CheckId(Id))
            {
                Console.Write("Enter 1 to Update Id\nEnter 2 to Name\nEnter 3 to Update Age\nEnter 4 to Update Standard\nEnter 5 to Update Address\nEnter Your Choice : ");
                byte n = byte.Parse(Console.ReadLine());
                try
                {
                    if (n > 5)
                    {
                        throw new Validation();
                    }
                }
                catch (Validation e)
                {
                    e.Input();
                }
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the new Id : ");
                        string m = Console.ReadLine();
                        studentservice.Update(n,Id, m);
                        Console.WriteLine("-------------------------");
                        break;
                    case 2:
                        Console.Write("Enter the New Name  : ");
                        string m1 = Console.ReadLine();
                        studentservice.Update(n, Id, m1);
                        break;
                    case 3:
                        Console.Write("Enter the New Age  : ");
                        string m2 = Console.ReadLine();
                        studentservice.Update(n,Id, m2);
                        break;
                    case 4:
                        Console.Write("Enter the New Standard  : ");
                        string m5 = Console.ReadLine();
                        studentservice.Update(n, Id ,m5);
                        break;
                        
                    case 5:
                        Console.Write("Enter the New Address  : ");
                        string m3 = Console.ReadLine();
                        studentservice.Update(n, Id, m3);
                        break;



                }           

            }
        }

        public void DeleteStudent()
        {
            try
            {
                Console.WriteLine("Enter Id:");
                string id = Console.ReadLine();
                if (studentservice.DeleteStudent(id))
                {
                    Console.WriteLine("Student deleted successfully");
                }
                else
                {
                    Console.WriteLine("Student Id is Not Found!");
                }
            }
            catch (Validation v)
            {
                v.Input();
                DeleteStudent();
            }
        }

    }
}
