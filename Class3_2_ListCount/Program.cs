using System;
using System.Collections.Generic;
using System.Linq;

namespace Class3_2_ListCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            Console.WriteLine(Sum.EvenSum(numbers));
            Console.ReadLine();

        } 
    }

    class Sum
    {
        public static int EvenSum (List<int> numbers)

        {
            int result = 0;

            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    result += number;
                }
            return result;
        }
    }
}
