using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract class submission");

            Employee one = new Employee() { FirstName = "Sample", LastName = "Student" };
            one.SayName();
            Console.ReadLine();
        }
    }
}
