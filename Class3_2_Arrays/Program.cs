using System;

namespace Class3_2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int item in MyArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
