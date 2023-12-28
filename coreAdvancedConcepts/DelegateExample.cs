using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

delegate int CalculateDelegate(int num);

namespace coreAdvancedConcepts
{
    internal class DelegateExample
    {
        static int number = 100;
        public static int Addition(int num)
        {
            number += num;
            return number;
        }

        public static int Multiplication(int num)
        {
            number *= num;
            return number;
        }

        public static int GetNumber() {
            return number;
        }
    }
}
