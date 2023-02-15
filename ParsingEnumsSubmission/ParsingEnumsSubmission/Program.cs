using System;

namespace ParsingEnumsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parsing enums assignment");

            //Asking the user to enter in a day of the week
            //if the user input matches a valid day it will be shown in the console
            //oterwise an error message will display
            try
            {
                Console.WriteLine("Please, enter the current day of the week:");
                string userDay = Console.ReadLine();
                Console.WriteLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                Console.WriteLine("Today is " + day + ".");
                Console.ReadLine();
            }
            catch (SystemException)
            {
                Console.WriteLine("Please, enter the actual day:");
                Console.ReadLine();
            }
        }

        // Creating an enum for the days of the week.
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }   
    }
}
