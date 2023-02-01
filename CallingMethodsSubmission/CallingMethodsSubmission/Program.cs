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
            Console.WriteLine("Please enter in a number to be added by 5");
            //Creating a variable to store the user's number
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter in a decimal to be subtracted by 5. \n the answer will be rounded to the nearest whole number");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("enter in an integer to be multiplied by 5");
            string userStr = Convert.ToString(Console.ReadLine());

            MyClass method = new MyClass();

            //Calling the methods one at a time and displaying the answers to the console
            int firstTotal = method.Method(userInput);
            Console.WriteLine(userInput + " plus " + 5 + " equals " + firstTotal);

            int secondTotal = method.Method(userDec);
            Console.WriteLine(userDec + " minus " + 5 + " equals " + secondTotal);

            int thirdTotal = method.Method(userStr);
            Console.WriteLine(userStr + " times " + 5 + " equals " + thirdTotal);

            Console.ReadLine();
        }
        
    }
}
