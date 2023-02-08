using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class submission");

            //asking the user to enter in a number
            Console.WriteLine("Please enter in a number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is your equation " + num1 + " divided by 2 equals " + result);

            //instantiating the class
            MyClass method = new MyClass();
            //Calling the method
            method.VoidMethod(num1);
        }
    }
}
