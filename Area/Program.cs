using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            float Radius;
            


            Console.WriteLine("Let's find the area of a circle");
            Console.WriteLine("What is the radius of the circle?");
            Input = Console.ReadLine();
            Radius = float.Parse(Input);


            Console.WriteLine(string.Concat("Area= ", Area.GetArea(Radius).ToString()));
            Console.ReadLine();


        }

    }
}

namespace Area
{
    public class Area
    {
        public static double GetArea(float Radius)
        {
            return 3.14 * Math.Pow(Radius, 2);


        }
    }
}