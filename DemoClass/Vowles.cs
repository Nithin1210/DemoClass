using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Vowles {
        public static void vow()
        {
           Console.WriteLine("Give a char :");
            char name = Convert.ToChar(Console.ReadLine());
            if(name =='a'|| name=='A' || name=='e'|| name=='E'|| name=='i'||name=='I'|| name == 'o' || name == 'O' || name == 'u' || name == 'U')
            {
                Console.WriteLine("vowel");
            }
            else { Console.WriteLine("Constants");
            }
            }
    

    }
}
