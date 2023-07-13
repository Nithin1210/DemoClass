using DemoClass;
using DemoOne;
using ProblemSolving;

internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter input to output   \n1).Addition \n2).OddEven \n3).Factorial \n4).Tables"
                + "\n5).Vowels \n6).Swaping \n7).flipCoin" + "\n8).LeapYear \n9).PowerOf2 \n10).Harmonic Number");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: 
                    Addition add = new Addition();
                    add.Add();
                    break;
                case 2:
                    OddEven.Fun();
                    break;
                case 3:
                    Factorial.Fact();
                    break;

                case 4:
                    Tables.Table();
                    break;
                case 5:
                    Vowles.vow();
                    break;
                case 6:
                    Swaping.swap();
                    break;
                case 7:
                    FlipCoin.Toss();
                    break;
                case 8:
                    LeapYear obj = new LeapYear();
                    obj.Year();
                    break;
                case 9:
                    PowerOf2.Power();
                    break;
                case 10:
                    HarmoncNumber harmoncNumber = new HarmoncNumber();
                    harmoncNumber.Harmonic();
                    break;



            }
        }


    }
}








//Tables.Table();
//Vowles.vow();


