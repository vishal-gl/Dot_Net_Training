using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Practice_Linq
{
    class Program
    {
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class Class1
        {
            public int Id { get; set; }
            public char Value { get; set; }
        }
        public class Class2
        {
            public int Id { get; set; }
            public string ChildValue { get; set; }
        }
        static void Main(string[] args)
        {
            //data Source
            string[] names = { "Abhi", "Wicked", "Harsh", "aakash" };
            //LINQ Query
            var nameWithA = from name in names
                            where name.Contains('a')
                            select name;
            foreach(string s in nameWithA)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();


            Student[] studentArray =
            {
                new Student(){ ID=1,Name ="Abhi",Age=18 },
                new Student(){ID=2,Name="Vishal",Age=22} ,
                new Student(){ID=3,Name="Vishali",Age=22} ,
                new Student(){ID=4,Name="Vinod",Age=26} ,
                new Student(){ID=5,Name="Vikruti",Age=20} ,
                new Student(){ID=6,Name="Vishalika",Age=27} ,
                new Student(){ID=7,Name="Vinayak",Age=28}
            };
            //Method Syntax
            Student bill = studentArray.Where(s => s.Name == "Vishali").FirstOrDefault();

            Student[] teens = studentArray.Where(s => s.Age > 12 && s.Age < 25).ToArray();

            //Linq to find student whose studentID is 5
            Student fifthStudent = studentArray.Where(s => s.ID == 5).FirstOrDefault();
            Console.WriteLine(bill.Name + ","+bill.Age+","+bill.ID+" : " + fifthStudent.Name);
            

            //2.OfType
            IList list1 = new ArrayList() { 0, "Abhi",1,"two", 3, 'g'};
            ArrayList list =new ArrayList() { 0, "Abhi", 1, "two", 3, 'g' };
            var onlyString = list.OfType<string>();
            foreach(var v in onlyString)
            {
                Console.WriteLine(v);
            }

            //OrderBy & OrderByDescending
            var sortedStudentList = studentArray.OrderBy(s => s.Age);
            var sortedStudentListDescending = studentArray.OrderByDescending(s => s.Age);
            foreach (var v in sortedStudentList)
            {
                Console.WriteLine(v.ToString());
            }

            //thenBy & ThenBy Decending
            var sortedStudentListThenName = studentArray.OrderBy(s => s.Age).ThenBy(s => s.Name);
            foreach(var v in sortedStudentListThenName)
            {
                Console.WriteLine(v);
            }

            //5 Group By & TOLookUp---Defferd_____Immediate
            var groupedResult = studentArray.GroupBy(s => s.Age);
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine("age Group : {0}", ageGroup.Key);//Each Group has a key
                foreach(Student s in ageGroup)
                {
                    Console.WriteLine("Student Name : {0}", s.ToString());

                }

            }
            
            //6. Join
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four" };

            var innerJoin = strList1.Join(strList2, str1 => str1, str2 => str2, (str1, str2) => str1);
            foreach(string s in innerJoin)
            {
                Console.WriteLine(s);
            }

            //7. Group Join
            List<Class1> listClass1 = new List<Class1>()
            {
                new Class1(){Id=1,Value='A'} ,
                new Class1(){Id=2,Value='B'} ,
                new Class1(){Id=3,Value='C'} ,

            };
            List<Class2> listClass2 = new List<Class2>()
            {
                new Class2(){Id=1,ChildValue="a1"} ,
                new Class2(){Id=1,ChildValue="a2"} ,
                new Class2(){Id=2,ChildValue="b1"} ,
                new Class2(){Id=2,ChildValue="b2"} ,

            };
            var groupJoin = listClass1.GroupJoin(listClass2, lc1 => lc1.Id,
                lc2 => lc2.Id,
                (value, childValue) => new
                {
                    Value = value,
                    childValues = childValue
                });
            foreach(var item in groupJoin)
            {
                Console.WriteLine(item.Value.Value);
                foreach(var v in item.childValues)
                {
                    Console.WriteLine(v.ChildValue + ",");
                }
                Console.WriteLine();
            }
            //8.Select & SelectMany
            var selectResult = studentArray.Select(s => new { StudentName = s.Name, Age = s.Age }).Where(s => s.Age > 19);
            foreach(var s in selectResult)
            {
                Console.WriteLine(s.StudentName);
                Console.WriteLine(s.Age);
            }
            var selectMany = studentArray.SelectMany(s => s.Name).ToList();
            foreach(var s in selectMany)
            {
                Console.WriteLine(s.ToString());
            }

            //9. All ,Any & Contains ---Qunatifiers Operator

            bool areAllStudentsTeenager = studentArray.All(s => s.Age > 12 && s.Age < 25);
            Console.WriteLine(areAllStudentsTeenager);

            bool areAnyStudentsTeenager = studentArray.Any(s => s.Age > 12 && s.Age < 25);
            Console.WriteLine(areAnyStudentsTeenager);

            Student std = new Student() { ID = 2, Name = "Vishalika", Age = 35 };
            Console.WriteLine(studentArray.Contains(std));
            //10 Elementary Operators

            var st = studentArray.FirstOrDefault(s => s.Name.Contains("a"));
            Console.WriteLine(st.Name);
            var st2 = studentArray.LastOrDefault(s => s.Name.Contains("a"));
            Console.WriteLine(st2.Name);






            Console.ReadLine();
        }
    }
}
