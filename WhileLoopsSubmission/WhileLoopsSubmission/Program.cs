using System;

namespace WhileLoopsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While loop submission assignment");

            //Regular while loop
            //declaring variable i as an integer and setting its
            //value at 0
            int i = 0;
            //while is less than 5 right out to the console
            //i while incrementing i by 1 until the condition
            // is met
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }
            Console.Read();


            Console.WriteLine("These are the results from my do while loop");
            //Declaring variable c as an integer and setting its value
            // to 0. The code block will be executed before the 
            //condition is checked as true. The program will stop
            //printint c once the condition is met.
            int c = 0;
            do
            {
                Console.WriteLine(c);
                c++;
            }
            while (c < 3);
        }   
    }
}
