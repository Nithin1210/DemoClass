using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class FlipCoin
    {
        public static void Toss()
        {
            Random random = new Random();
            Console.WriteLine("Enter the n.o times to flip");
            int num = Convert.ToInt32(Console.ReadLine());
            int headCount = 0, tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                double check = random.NextDouble();
                if (check < 0.5)
                    tailCount++;
                else
                    headCount++;

            }
            Console.WriteLine("percentage of head " + " " + (100* headCount / num ));
        }
    }
}
