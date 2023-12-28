using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday = 13,
        Friday,
        Saturday,
        Sunday
    }
    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Monday);
        }
    }
}
