using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    partial class Employee
    {
        internal int EmployeeID { get; set; }
        internal string EmployeeName { get; set; } = string.Empty;

        internal partial void DisplayDetails();
    }
}
