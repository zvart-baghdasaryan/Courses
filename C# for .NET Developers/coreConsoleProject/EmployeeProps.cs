using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    internal partial class Employee
    {
        public int EmpId;
        public string? EmpName;
        public partial void EmployeeDetails();
    }
}