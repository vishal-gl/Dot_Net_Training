using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Expression_Tree_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(10), Expression.Constant(2));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Divide, Expression.Constant(10), Expression.Constant(5));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(10), Expression.Constant(1));
            BinaryExpression b4 = Expression.MakeBinary(ExpressionType.Add, b1, b2);
            BinaryExpression b5 = Expression.MakeBinary(ExpressionType.Subtract, b4, b3);
            int result = Expression.Lambda<Func<int>>(b5).Compile()();
            Console.WriteLine("Expression Value (10*2)+(10/5)-(10-1) : {0}",result);

            //Expression tress help out to execute dynamic expression calculation as above

            
            Expression<Func<int, bool>> lambda = num => num < 6;
            bool result1 = lambda.Compile()(8);
            Console.WriteLine("Is Num=8 is less than 6 or not : ",result1);
            Console.ReadLine();
        }
    }
}
