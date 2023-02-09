using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Method_Class_Submission
{
    public class voidMethod
    {
        public void methodOne(double var1, double var2) 
        {
            double result = var1 * 3;
            Console.WriteLine("{0}, times 3 equals " + result + ".", var1);
            Console.WriteLine("{0} will not be included in any equation", var2);
            
            return;
        }
    }
}
