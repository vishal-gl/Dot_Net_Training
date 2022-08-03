using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class class1
    {
        public void sum1(int a)
        {
            int result = 89;
            Console.WriteLine(result);
        }
        public abstract int sub(int a,int b);
            

    }
    class class2 : class1
    {
        public override int sub(int a,int b)
        {
      
            return a - b;
        }
    }
    class Add : class1
    {
        public override int sub(int a, int b)
        {
           
            return a-(-b);
        }
    }
    class class3 : class2
    {
        public void sum2(int a,int b)
        {
            int k=a + b;
            Console.WriteLine(k);
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            class3 obj = new class3();
            Add obj2 = new Add();
            obj.sum1(7);
            int res=obj.sub(3, 4);
            int res2 = obj2.sub(3, 4);
            obj.sum2(6,7);
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}
