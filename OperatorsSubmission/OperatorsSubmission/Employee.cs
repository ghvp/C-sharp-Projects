using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    //created employee class with ID first and last name. 
    //overloading using the == operator to compare the employee objects
    //by their ID
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a.Id != b.Id);
        }
    }
}
