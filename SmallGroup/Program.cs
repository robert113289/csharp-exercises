using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "i", "am", "in", "a", "list!" };

            if (list1.Contains("loop"))
            {
                Console.WriteLine("its in there");
            }
            else
            {
                list1.Add("loop");
            }


            StringBuilder MyStringBuilder = new StringBuilder();

            for (int i = 0; i < list1.Count; i++)
            {
                MyStringBuilder.Append(list1[i] + " ");

             
            }
            string string1 = MyStringBuilder.ToString();

            List<string> list2 = string1.Split(" ").ToList();

             



            Console.WriteLine(list2);


            Dictionary<string, string> definitions = new Dictionary<string, string>();

            definitions.Add("c#", "Holistically, C# is perhaps the best programming language in existence.");

            foreach (var item in definitions)
            {
                Console.WriteLine(item);
            }

            if (!definitions.ContainsKey("obstreperous")) 
            {
                Console.WriteLine("Im going to fail the sat");
            }

            int id;

            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "george");
            names.Add(2, "alex");

            Console.WriteLine("id:");
            string input = Console.ReadLine();
            id = int.Parse(input);

            if (names.ContainsKey(id))
            {
                Console.WriteLine(names[id]);
            }
            else
            {
                Console.WriteLine("id doesnt exist");
            }

            IDictionary<string, (string,string),(string,string)> dictionary = new IDictionary<string,(string, string),(string,string)>();

            dictionary.Add("hey", ("spanish", "hola"),("french","bonjour");

            




            Console.ReadLine();
        }
    }
}
