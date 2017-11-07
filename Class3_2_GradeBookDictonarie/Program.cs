using System;
using System.Collections.Generic;
using System.Text;

namespace Class3_2_GradeBookDictonarie
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> GradeBook = new Dictionary<int, string>();
            int Id;
            string Name;
            string input;



            do
            {
                Console.WriteLine("Enter student ID:");
                input = Console.ReadLine();
                

                if (input != "")
                {
                    Id = int.Parse(input);
                    Console.WriteLine("Enter student name:");
                    input = Console.ReadLine();
                    Name = input;

                    GradeBook.Add(Id, Name);
                }


            }
            while (input != "");


            //print roster

            //           foreach (KeyValuePair<int,string> student in GradeBook)
            //         {
            //           Console.WriteLine("Id=" + student.Key + " (" + student.Value + ")");
            //     }

            // Print class roster using string builder
            Console.WriteLine("\nClass roster:");


            StringBuilder MyStringBuilder = new StringBuilder("Student=");


            foreach (KeyValuePair<int, string> student in GradeBook)
            {
                MyStringBuilder.Append(student);
                
            }
            Console.WriteLine(MyStringBuilder);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
