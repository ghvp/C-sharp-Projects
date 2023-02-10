using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods and Objects submission assignment");
            //instantiating and intializing the employee object with a sample 
            //first and last name. 
            Employee one = new Employee() { FirstName = "Sample", LastName = "Student" };
            //calling the sayname method that is inside the person class on the employee object
            one.SayName();
            Console.ReadLine();
        }
    }
}
