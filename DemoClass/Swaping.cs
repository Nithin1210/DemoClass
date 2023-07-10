using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Swaping
    {
        public static void swap()
        {
            Console.WriteLine("Enter the 1st number :");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The 2nd Number :");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("First number :"+a + "  ,  " + "SecondNumnber: " + b); 
        }
    }
}
