using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    public class Person
    {
        //Created the Person class and gave it 2 string properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Creating the void method
        public void SayName()
        {
            //outputs the full name to the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
