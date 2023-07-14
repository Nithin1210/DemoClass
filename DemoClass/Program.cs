using DemoClass;
using DemoOne;
using ProblemSolving;
using ProblemStatement2;

internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter input to output   \n1).FlipCoin \n2).LeapYear \n3).PowerOf2 \n4).HarmoncNumber \n5).Factorial" +
                                                      " \n6)Division \n7)Swaping \n8)OddEven\n9)Vowles\n10)LargestAmongThree");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    FlipCoin.Toss();
                    break;
                case 2:
                    LeapYear obj = new LeapYear();
                    obj.Year();
                    break;
                case 3:
                    PowerOf2.Power();
                    break;
                case 4:
                    HarmoncNumber harmoncNumber = new HarmoncNumber();
                    harmoncNumber.Harmonic();
                    break;
                case 5:
                    Factorial.Fact();
                    break;
                case 6:
                    Division.divide();
                    break;
                case 7:
                    Swaping.swap();
                    break;
                case 8:
                    OddEven.Fun();
                    break;
                case 9:
                    Vowles.vow();
                    break;
                case 10:
                    LargestAmongThree.Largest();
                    break;


          

            }
        }


    }
}





