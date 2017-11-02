using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> Students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish:");

            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    Students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in Students)
            {
                Console.WriteLine("Grade for " + student + ":");

                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print roster
            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine(Students[i] + "(" + grades[i] + ")");
            }

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();

        }
    }
}