using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("<<< COMPUTE AVERAGE APP >>>");
            Console.WriteLine("Enter 5 Numeric Grades to Compute The Average (New line for each) ");
            Console.Write("First: ");
            double first = Convert.ToDouble(Console.ReadLine());   
            Console.Write("Second: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third: ");
            double third = Convert.ToDouble(Console.ReadLine());    
            Console.Write("Fourth: ");
            double fourth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fifth: ");
            double fifth = Convert.ToDouble(Console.ReadLine());  
            
            double averages = (first + second + third + fourth + fifth)/5;
            double rounded = Math.Round(averages);

            Console.WriteLine("\n<<< RESULTS >>>");
            Console.WriteLine("The total average is " + "'" + averages + "'" + " and rounded off to " + "'" + rounded + "'" + ".");
            Console.ReadKey();








        }
    }
}
