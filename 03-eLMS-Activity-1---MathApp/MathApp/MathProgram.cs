using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< 5 DIFFERENT METHODS OF THE MATH CLASS >>>");
            Console.Write("Enter a number (Decimal Allowed): ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number (Decimal Allowed) : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("<<< RESULTS >>>");
            double power = Math.Pow(num1, num2);
            Console.Write("1) Using Math.Pow (" + num1 + ", " + num2 + ") = " + power);
            double exp = Math.Exp(num1);
            Console.Write("\n2) Using Math.Exp (" + num1 + ") = " + exp);
            double root = Math.Sqrt(num2);
            Console.Write("\n3) Using Math.Sqrt (" + num2 + ") = " + root);
            double abs = Math.Abs(num2);
            Console.Write("\n4) Using Math.Abs (" + num2 + ") = " + abs);
            double sign = Math.Sign(num1);
            Console.Write("\n5) Using Math.Sign (" + num1 + ") = " + sign);

            Console.ReadKey();

        }
    }
}