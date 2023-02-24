using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first number");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nwelcome back {uName}. today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\maggi\OneDrive\Documents\GitHub\C-sharp-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent scores: \n");
            foreach (string line in lines) 
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n total of " + lines.Length + " student scores: \tAverage score " + avgScore);

            Console.WriteLine("\n \nPress any key to exit!");
            //will exit the program if the user presses any key
            Console.ReadKey();
        }
    }
}
