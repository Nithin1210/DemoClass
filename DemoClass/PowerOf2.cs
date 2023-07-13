﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class PowerOf2
    {
        public static void Power()
        {
            Console.WriteLine("Enter the power value N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 0 || N >= 31)
            {
                Console.WriteLine("Invalid value  N. N should be between the value of : 0 and 30.");
                return;
            }

            Console.WriteLine("Powers of 2 up to 2^" + N + ":");

            for (int i = 0; i <= N; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine("2^" + i + " = " + power);
            }
        }
    }
}