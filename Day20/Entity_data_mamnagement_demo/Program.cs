using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_data_mamnagement_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SampleDBEntities())
            {
                var result = context.Students;
                foreach(var item in result)
                {
                    Console.WriteLine("Name :{0} ",item.Name);
                    Console.WriteLine("Name : {0}",item.Id);
                    Console.WriteLine("Name : {0}", item.Standard);


                }
            }
            Console.ReadLine();
                
        }
    }
}
