using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling methods assignment");

            //prompting the user to enter in a number to use
            //for our methods
            Console.WriteLine("Please enter in a number to use for the following equations. Addition, subtraction, and multiplication");
            //Creating a variable to store the user's number
            int userInput = Convert.ToInt32(Console.ReadLine());

            
            MyClass method = new MyClass();

            //Calling the methods one at a time and displaying the answers to the console
            int firstTotal = method.Method1(userInput);
            Console.WriteLine(userInput + " plus " + 5 + " equals " + firstTotal);

            int secondTotal = method.Method2(userInput);
            Console.WriteLine(userInput + " minus " + 5 + " equals " + secondTotal);

            int thirdTotal = method.Method3(userInput);
            Console.WriteLine(userInput + " times " + 5 + " equals " + thirdTotal);

            Console.ReadLine();
        }
        
    }
}
