using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //START OF APPLICANT INFORMATION
            //Printing text to the console
            Console.WriteLine("How old are you");
            //Alows user input
            string Age = Console.ReadLine();
            //Applicant must be 15 to qualify 

            //Printing text to the console
            Console.WriteLine("Have you ever had a DUI? Please enter \'true\' or \'false'");
            //Allows user input
            bool DUI = false;
            string HasDUI = Console.ReadLine();
            //I'm not too sure how to implement this part.. would i convert the user input into a bool?
            //Applicant cannot have any DUIs 

            //Printing text to the console
            Console.WriteLine("How many speeding tickets do you have? (Please use numerical values)");
            //Allows user input
            string Tickets = Console.ReadLine();
            //Applicant cannot have more than 3 speeding tickets 
            //END OF APPLICANT INFORMATION


            //START OF VALIDATING APPLICANT INFO USING BOOLEAN AND CONVERTING THE VARIABLES 
            //Converting var Age into an intger for easier bool validation 
            int ApplicantAge = Convert.ToInt32(Age);
            //bool for validating age
            bool AgeOk = ApplicantAge >= 15;

            //converting DUI var to be accepted into a bool
            //unsure how to implement.. see comment on line 21

            //checking if applicant has more than 3 speeding tickets
            int TotalTickets = Convert.ToInt32(Tickets);
            bool TicketsOk = TotalTickets < 3;

            //Checks if applicant qualifies 
            bool Qualified = AgeOk && TicketsOk;
            string ShowQualified = Convert.ToString(Qualified);
            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);

            


        }
    }
}
