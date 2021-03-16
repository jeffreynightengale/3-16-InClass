using System;

namespace InClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string[] studentIds = new string[3];
            for (int i = 0; i < studentIds.Length; i++)
            {
                studentIds[i] = rand.Next(1300000, 1400000).ToString();
            }

            double[] studentGpas = { 3.0, 4.0, 2.7 };

            //Display all the ID's
            //for (int i = 0; i < studentIds.Length; i++)
            //{
            //    string id = studentIds[i];
            //    Console.Write($"\t {id}");
            //}
            
            //Doing exactly what is stated above
            foreach (string id in studentIds)
            {
                Console.Write($"\t {id}");
            }

            Console.WriteLine("\nWhose GPA do you want to see? >>?");
            string idToLookFor = Console.ReadLine();

            for (int i = 0; i < studentGpas.Length; i++)
            {
                if (studentIds[i] == idToLookFor)
                {
                    Console.WriteLine($"{idToLookFor} has a {studentGpas[i].ToString("N2")}");
                }
            }
        }
    }
}
