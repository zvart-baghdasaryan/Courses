using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    internal partial class Employee
    {
        public partial void EmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
        }
    }
}