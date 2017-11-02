using System;

namespace HelloMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("fr");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    }
}
namespace HelloMethods
{
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else
            {
                return "Hello World";
            }
        }
        
    }
}