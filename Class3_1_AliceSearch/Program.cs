using System;

namespace Class3_1_AliceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            String Story;
            String Input;
            Boolean Result;

            Story = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Lets search for a phrase or word in an exerpt from Alice in Wonderland");
            Console.WriteLine("What would you like to search for?");
            Input = Console.ReadLine();
            
            Result = Story.ToLower().Contains(Input.ToLower());

            Console.WriteLine(Result);

          
            Console.ReadLine();
        }
    }
}
