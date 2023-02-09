using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter in their first number
            Console.WriteLine("Please enter in your first number");
            double Usernum1 = Convert.ToDouble(Console.ReadLine());
            //asks user to input their second number
            Console.WriteLine("Now enter in your second number");
            double Usernum2 = Convert.ToDouble(Console.ReadLine());

            //methodOne is called from voidMethod 
            //the first num is passed through an equation while the second num will
            //display on its own
            voidMethod method = new voidMethod();
            //Calling the named parameters
            method.methodOne(var1:Usernum1, var2:Usernum2);

            Console.ReadLine();

        }
    }
}
