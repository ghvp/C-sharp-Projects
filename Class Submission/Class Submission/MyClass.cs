using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Class_Submission
{
    public class MyClass
    {
        //Creating a void method with some parameters
        //num 1 is assigned a value then is divided 2
        //it'll output a total of num2 which is entered in by the user
        public void VoidMethod(out int num1, int num2) 
        {
            num1 = 100;
            int result1 = num1 / 2;
            int result2 = num2 / 2;
            Console.WriteLine(num1 + " divided by 2 is " + result1);
            Console.WriteLine("{0} divided by 2 equals " + result2, num2);
            return;
        }

        //Overloading the method by changing the number of parameters
        //outputs the static fields from the static class
        public int methodOne() 
        {
            int TotalStat = StaticClass.num1 * StaticClass.num2;
            Console.WriteLine(StaticClass.num1 + " multiplied by " + StaticClass.num2 + " is " + TotalStat);
            return TotalStat;
        }
    }
}
