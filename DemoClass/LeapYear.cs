using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter a year number: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))) 
            Console.WriteLine("leapYear");
            else {
                Console.WriteLine("Non leapYear");
            }
        }
    }
}










// A year is a leap year if it is divisible by 4,
// except for years that are divisible by 100 but not divisible by 400
