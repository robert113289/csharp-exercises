using System;

namespace Class3_1_AreaOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int Length;
            int Width;
            int Area;
            

            Console.WriteLine("Lets Calculate the area of a rectangle");

            Console.WriteLine("What is the length?");
            input = Console.ReadLine();
            Length = int.Parse(input);

            Console.WriteLine("What is the width?");
            input = Console.ReadLine();
            Width = int.Parse(input);

            Area = Length * Width;

            Console.WriteLine("The area of the rectangle= " + Area.ToString());
            Console.ReadLine();







            Console.WriteLine("Area= ");
        }
    }
}
