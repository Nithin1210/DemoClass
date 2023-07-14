using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement2
{
    public class Division
    {
        public static void divide()
        {
            Console.WriteLine("Enter Dividend");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");

            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient : " + num1 / num2);
            Console.WriteLine("Remainder : " + num2 % num2);
        }
    }
}