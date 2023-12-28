using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal partial class Employee
    {
        internal partial void DisplayDetails()
        {
            Console.WriteLine(this.EmployeeID);
            Console.WriteLine(this.EmployeeName);
        }
    }
}
