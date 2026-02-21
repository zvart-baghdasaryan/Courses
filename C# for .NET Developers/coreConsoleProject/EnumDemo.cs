using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enamDemo
{
    enum WeekDays:byte
    {
        Mo = 5,     //0
        Th = 10,   //1
        We = 15,  //2
        Thu = 25,   //3
        Fr,     //4
        Sa = 30,   //5
        Su      //6

    }
    internal class EnumDemo
    {
        public void displayWeekDays()
        {
            Console.WriteLine(WeekDays.Mo);
            int day = (int)WeekDays.Mo;
            Console.WriteLine(WeekDays.Mo + ":" + day);
            Console.WriteLine(WeekDays.Th);
            day = (int)WeekDays.Th;
            Console.WriteLine(WeekDays.Th + ":" + day);
            Console.WriteLine(WeekDays.We);
            day = (int)WeekDays.We;
            Console.WriteLine(WeekDays.We + ":" + day);
        }
    }
}