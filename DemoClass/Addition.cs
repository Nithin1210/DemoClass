using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    internal class Addition
    {
        public void Add()
        {
            Console.WriteLine("enter a and b values");
            int a = (Convert.ToInt32(Console.ReadLine()));
            int b = (Convert.ToInt32(Console.ReadLine()));
            int x = a + b;
            Console.WriteLine("Add valves is : " + " " + x);
        }

        public static void Sub()
        {
            Console.WriteLine("enter a and b values");
            int a = (Convert.ToInt32(Console.ReadLine()));
            int b = (Convert.ToInt32(Console.ReadLine()));
            int x = a - b;
            Console.WriteLine("sub values is : " + " " + x);
        }
    }
}
