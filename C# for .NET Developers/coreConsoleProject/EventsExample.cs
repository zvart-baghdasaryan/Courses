using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsExample
{
    //The Publisher Model
    internal class EventsExample
    {
        //Declare Delegate
        public delegate void delegate_OddNumber();
        //Declare Event
        public event delegate_OddNumber event_OddNumber;

        public void addition()
        {
            int num1 = 100; int num2 = 200;
            int result = num1 + num2;
            Console.WriteLine(result);
            if(result % 2 !=0 && event_OddNumber != null)
            {
                //Raised Event
                event_OddNumber();
            }
        }
    }
}