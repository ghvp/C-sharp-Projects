using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethodsSubmission
{
    class MyClass
    {
        //Creating my first method and allowing it to take the parameter var
        public int Method(int var) 
        {
            //creating a variable to display the total 
            //of the user inputted number plus 20
            //this method adds 5 to the user input
            int firstTotal = var + 5;
            //returning the total to the console
            return firstTotal;
        }
        public int Method(decimal var) 
        {
            //same function and format as the code block above
            //this method subtracts 5 from the user input
            decimal total2Decimal = var - 5;
            int secondTotal = Convert.ToInt32(total2Decimal);
            return secondTotal;
        }
        public int Method(string var) 
        {
            //same function and format as the code block above
            //this method multiplies the user input by 5
            try
            {
                int thirdTotal = Convert.ToInt32(var) * 5;
                return thirdTotal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
