using System;

namespace Daily_report
{
    class Program
    {
        static void Main()
        {   //This block of code just asks regular questions that take in the string data type
            //The Console.readline allow for user input to be saved inside the variables
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You're on the " + courseName + " course awesome!");

            //Questions that take integers as variables. I made these into the string data type because it was easier
            //The numbers the user had to enter in wouldn't be used for anything other than displaying them on the console. 
            //This is why I chose to keep it as a string
            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            Console.WriteLine("You're on page " + pageNum);

            //Kept the bool values as a string for the same reason above also I wasn't sure how to convert both true or false values into a string
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            Console.WriteLine("You entered " + help);

            //Questions that take in the string value
            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific");
            Console.ReadLine();
            Console.WriteLine("Happy to hear that from you!");
            Console.WriteLine("Is there any feedback you'd like to share? Please be specific");
            Console.ReadLine();

           
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Good job studying " + hoursStudied + " hours");


            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day");
            Console.ReadLine();

        }
    }
}
