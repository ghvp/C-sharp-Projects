using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints text to the console
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //START PERSON 1 INFO
            //Prints text to the console
            Console.WriteLine("Person 1");
            //Prompts the user to enter in their hourly rate
            Console.WriteLine("Please enter your hourly rate");
            //Allows the user to enter in their hourly rate
            string Person1Hourly = Console.ReadLine();
            //The user will enter in their Hours worked weekly
            Console.WriteLine("Please enter your hours worked per week");
            string Person1Weekly = Console.ReadLine();
            //END OF PERSON 1 INFO


            //START OF PERSON 2 INFO
            //this chunk of code will follow the same format as 
            //the code above and will have the same functionality
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate");
            string Person2Hourly = Console.ReadLine();
            Console.WriteLine("Please enter your hours worked per week");
            string Person2Weekly = Console.ReadLine();
            //END OF PERSON 2 INFO


            //START OF DISPLAYING PERSON 1'S SALARY TO THE CONSOLE
            //Prints text to the console
            Console.WriteLine("Annual Salary of Person 1: ");
            //Converting the variables for Person 1 into from strings
            //to integers to allow for them to be multiplied
            int P1Hourly = Convert.ToInt32(Person1Hourly);
            int P1Weekly = Convert.ToInt32(Person1Weekly);
            //Multiplies the converted variables above
            int result1 = P1Weekly * P1Hourly * 52;
            //Prints Person 1's salary to the console as a string
            Console.WriteLine(result1.ToString());
            //END OF DISPLAYING PERSON 1'S SALARY


            //START OF DISPLAYING PERSON 2'S SALARY TO THE CONSOLE
            //Functions exactly the same as the block of code above.
            Console.WriteLine("Annual Salary of Person 2: ");
            int P2Hourly = Convert.ToInt32(Person2Hourly);
            int P2Weekly = Convert.ToInt32(Person2Weekly);
            int result2 = P2Weekly * P2Hourly * 52;
            Console.WriteLine(result2.ToString());


            //START OF COMPARING THE SALARIES 
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareSalary = result1 > result2;
            Console.WriteLine(compareSalary.ToString());




        }
    }
}
