using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    internal class Factorial
    {
        public static void Fact()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;

            }
            Console.WriteLine(result);
        }
    }
}
