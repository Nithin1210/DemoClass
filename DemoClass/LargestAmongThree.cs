using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class LargestAmongThree
    {
        public  static void Largest()
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largestNumber = Math.Max(Math.Max(num1, num2), num3);

            Console.WriteLine("The largest number is: " + largestNumber);

        }
    }
}