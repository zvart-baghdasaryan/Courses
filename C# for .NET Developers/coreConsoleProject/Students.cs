using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class Student
    {
        //Data Members
        private int studentId;
        private string studentName;

        //Default Constructor
        public Student()
        {
            studentId = 101;
            studentName = "Annonymous";
        }
      
        //Parameterized Constructor
        public Student(int sId, string sName)
        {
            studentId = sId;
            studentName = sName;
        }
      

        //Member Functions
    
        public void acceptDetails()
        {
            Console.Write("Enter Student Id:");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name:");
            studentName = Console.ReadLine();
        }
        
        public void displayDetails()
        {
            Console.WriteLine("Student id:" + studentId);
            Console.WriteLine("Student Name:" + studentName);
        }
    }
}

