using System;
using System.Collections.Generic;

namespace InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();

            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.7);

            foreach (var studentID in students.Keys)
            {
                Console.Write($"\t {studentID}");
            }

            Console.WriteLine("\nWhose GPA do you want to see? >>?");
            string idToLookFor = Console.ReadLine();

            if (students.ContainsKey(idToLookFor) == true)
            {
                Console.WriteLine( $"{idToLookFor} has a {students[idToLookFor].ToString("N2")}"); 
            }
            else
            {
                Console.WriteLine($"{idToLookFor} is not a valid student.");
                Environment.Exit(-1);
            }

            
        }
    }
}
