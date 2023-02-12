using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    //inherits from the person class
    class Employee : Person 
    {
        public override void SayName()
        {
            //Printing out the full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
