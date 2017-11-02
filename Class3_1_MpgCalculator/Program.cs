using System;

namespace Class3_1_MpgCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Miles_Driven;
            int Gas_Used;
            int Mpg;
            string Input;

            Console.WriteLine("Lets calculate your gas Milage!");

            Console.WriteLine("How many miles have you traveled?");
            Input = Console.ReadLine();
            Miles_Driven = int.Parse(Input);

            Console.WriteLine("How many gallons of gas have you used?");
            Input = Console.ReadLine();
            Gas_Used = int.Parse(Input);

            Mpg = Miles_Driven / Gas_Used;


            Console.WriteLine(string.Concat("You have gotten " , Mpg.ToString(), " Mpg"));
            Console.ReadLine();
        }
    }
}
