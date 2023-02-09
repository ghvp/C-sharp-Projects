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

            //Asking the user to enter in an integer
            //Converting the data types for num1 and num2
            Console.WriteLine("Please enter in an integer. It will be divided by 2");
            int num1;
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Display the assigned value of num1 / 2
            //through Class Myclass > methodOne
            //num2 is divided by 2 and the static fields from staticClass
            MyClass method = new MyClass();
            method.methodOne(out num1, num2);

            int Total = num1 + num2;
            Console.WriteLine(num1 + " plus " + num2 + " equals " + Total);

            method.methodOne();

            Console.ReadLine();

        }
    }
}
