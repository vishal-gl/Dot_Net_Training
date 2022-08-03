using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Prameter
{
    class Program
    {
        //This method contains two regular
        //parameter ,i.e. ename and eid
        //and two optional parameters,i.e
        //bgrp and dept
        static public void details(string ename, int eid, string bgrp = "A+", string dept = "Review - Team")
        {
            Console.WriteLine("Employee Name: {0}", ename);
            Console.WriteLine("Employee Id: {0}", eid);
            Console.WriteLine("Blood Group: {0}", bgrp);
            Console.WriteLine("Department Name: {0}", dept);


        }
        private int Add(int x,int y,int z)
        {
            return x + y + z;
        }
        public static void mulval(dynamic val)
        {
            val *= val;
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            details("pqrs",34);
            details("Abcs", 14);
            //calling the detail method
            details("XYZ\n", 123);
            details("ABC\n", 123,"A");
            details("XYZ\n", 123,"B=","software departmente");


            //named parameters
            Program ps = new Program();
            int result = ps.Add(y: 50, x: 20, z: 67);
            Console.WriteLine("Instance method" + result);


            //dyanamic parameter
            mulval(30);
            Console.ReadLine();

        }
    }
}
