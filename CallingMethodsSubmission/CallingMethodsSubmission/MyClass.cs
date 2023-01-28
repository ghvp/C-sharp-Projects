using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsSubmission
{
    class MyClass
    {
        //Creating my first method and allowing it to take the parameter var
        public int Method1(int var) 
        {
            //creating a variable to display the total 
            //of the user inputted number plus 20
            //this method adds 5 to the user input
            int firstTotal = var + 5;
            //returning the total to the console
            return firstTotal;
        }
        public int Method2(int var) 
        {
            //same function and format as the code block above
            //this method subtracts 5 from the user input
            int secondTotal = var - 5;
            return secondTotal;
        }
        public int Method3(int var) 
        {
            //same function and format as the code block above
            //this method multiplies the user input by 5
            int thirdTotal = var * 5;
            return thirdTotal;
        }
    }
}
