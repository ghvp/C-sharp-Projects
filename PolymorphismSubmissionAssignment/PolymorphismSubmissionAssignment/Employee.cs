using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    //Created an employee class that inherits from person and iquittable
    public class Employee : Person, IQuittable
    {
        static public int Id;

        public void Quit(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
