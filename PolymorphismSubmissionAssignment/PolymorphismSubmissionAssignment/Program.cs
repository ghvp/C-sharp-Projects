using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IQuittable one = new Employee();
            one.Quit("Sample", "Student");
            Console.ReadLine();
        }
    }
}
