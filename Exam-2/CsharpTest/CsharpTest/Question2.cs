using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArithmeticCL;

namespace CsharpTest
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            ArithmeticOperations obj = new ArithmeticOperations();
            Console.WriteLine("Sum of Two Numbers is :" + obj.Addition(10, 20));
            Console.WriteLine("Sub of Two Numbers is :"+obj.Subtraction(10, 20));
            Console.WriteLine("Mul of Two Numbers is :" + obj.Multiplication(10, 20));
            Console.WriteLine("Div of Two Numbers is :" + obj.Division(10, 2));
        }
    }
}


