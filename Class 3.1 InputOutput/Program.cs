using System;

namespace Class3_1_InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");
            string UserInput = Console.ReadLine();
            Console.WriteLine("Hello " + UserInput);
            Console.ReadLine();
        }
    }
}
