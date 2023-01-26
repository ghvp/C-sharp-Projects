using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings and Integers submission assignment");

            //Creating a list of integers
            List<int> NumberList = new List<int>() { 4, 8, 12, 16 };

            //Creating a try and catch block
            try
            {
                //Asking the user to enter in a num to divide all nums in the list by
                Console.WriteLine("Please enter in a number to divde all items in the list by");
                int NumberInput = Convert.ToInt32(Console.ReadLine());
                //Loop that divides each num in the list by the number entered in by the user
                foreach (int num in NumberList)
                {
                    //Creating a new variable to store the answer and display it to the user
                    int result = num / NumberInput;
                    //prints the result of the numbers in the strings divided by the user number
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex) 
            {
                //Catches an error that arrises with the user tries to
                //divide by zero and will display an error message
                Console.WriteLine("Please don't divide by zero " + ex.Message);
            }
            catch (FormatException ex) 
            {
                //catches an error that arrises from the user trying to 
                //divide using a string and displays an error message
                Console.WriteLine("Please only use whole numbers! " + ex.Message);
            } 
            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
