using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{   
    //created a person class and gave it two string properties
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Printing first and last name 
        public void SayName()
        {
            Console.Write("Name: " + FirstName + " " + LastName);
        }
    }
}
