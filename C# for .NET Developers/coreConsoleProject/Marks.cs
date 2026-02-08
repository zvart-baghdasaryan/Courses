using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectInheritance
{
    internal class Marks : StudentInfo
    {
        float objectiveMarks;
        float subjectiveMarks;
        public void accept()
        {
            base.accept();
            Console.Write("Enter Objective Marks:");
            objectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks:");
            subjectiveMarks = float.Parse(Console.ReadLine());
        }
        public void display()
        {
            base.accept();
            Console.WriteLine("Objective Marks:" + objectiveMarks);
            Console.WriteLine("Subjective Marks:" + subjectiveMarks);
        }
    }
}