using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Tables
    {
        public static void Table()
        {
            Console.WriteLine("Enter the Table");
            int input=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 10 ; i++) {
                Console.WriteLine(i * input);
                    }
        }


    }
}
