using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectInheritance
{
    internal class StudentInfo
    {
        private int studentId;
        private string studentName;
        public void accept()
        {
            Console.Write("Enter Student Id:");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name:");
            studentName = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Student ID:" + studentId);
            Console.WriteLine("Student Name:" + studentName);
        }
    }
}