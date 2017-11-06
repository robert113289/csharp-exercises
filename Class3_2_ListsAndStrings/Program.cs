using System;
using System.Collections.Generic;

namespace Class3_2_ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> words = new List<string> { "five", "taco", "peach", "mississippi", "truck" };


            SearchFive(words);

            Console.ReadLine();
        }

        public static List<string> SearchFive(List<string> words)
        {
            List<string> NewWordList = new List<string> ();

            foreach (string word in words)
            {
                int Length = word.Length;
                
                if (Length == 5)
                {
                    Console.WriteLine(word);
                    NewWordList.Add(word);
                }
            }
            return NewWordList;
        }
    }

}
