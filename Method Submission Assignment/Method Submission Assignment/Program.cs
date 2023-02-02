using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter in an integer and then an optional secondary integer
            Console.WriteLine("Hello! Please enter in one integer(s)");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in a second integer (This is optional)");
            string userInput = Console.ReadLine();

            Console.WriteLine("Now lets calculate the total of your integer(s) plus 8");
            System.Threading.Thread.Sleep(1000);

            Twointegers method = new Twointegers();

            //If the user does not enter in the optional integer a message will display 
            //letting them know that they did not enter in that optional int. The method
            //will be called and the int the user entered in will then be added with 
            //the number 8 and the result will be displayed 
            if (userInput == "")
            {
                double num1Total = num1 + 8;
                double Total2 = method.method(num1Total);
                Console.WriteLine("You didn't enter a second integer so here is your equation and total " + num1 + " + " + 8 + " = " + num1Total);
            }
            //if the user enters in the optional int the method will be called
            //and will include both entered in integers added to each other
            //and then added by 8
            else if (userInput != null) 
            {
                double userTotal = Double.Parse(userInput);
                double total = method.method(num1, userTotal);
                Console.WriteLine(num1 + " + " + userTotal + " + " + " 8 " + " = " + total);
            }
            Console.ReadLine();
        }
    }
}
