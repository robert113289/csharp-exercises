using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's find the area of a circle");
            Console.WriteLine(string.Concat("Area= ", Area.GetArea().ToString()));
            Console.ReadLine();


        }

    }
}

namespace Area
{
    public class Area
    {
        public static double GetArea()
        {
            string Input;
            float Radius;



           
            Console.WriteLine("What is the radius of the circle?");
            Input = Console.ReadLine();
            Radius = float.Parse(Input);

            if (Radius < 0)
            {
                Console.WriteLine("You cannot have a radius less that is negative");
                return GetArea();
            }
            return 3.14 * Math.Pow(Radius, 2);


        }
    }
}