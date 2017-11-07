using System;
using System.Collections.Generic;
using System.Linq;
namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();
            int Count = 0;

            foreach (char letter in input)
            {



                if (CharacterCount.ContainsKey(letter))
                {
                    CharacterCount[letter] += 1;

                }

                else
                {
                    CharacterCount.Add(letter, 1);

                }
             
            }

            foreach (KeyValuePair<char, int> item in CharacterCount)
            {
                Console.WriteLine(item.Key +":" + " (" + item.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
