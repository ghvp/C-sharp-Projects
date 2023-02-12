using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person
    {
        //giving the person class 2 string properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Creating an abstract method
        public abstract void SayName();
    }
}
