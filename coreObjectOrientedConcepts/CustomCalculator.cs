using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    static class CustomCalculator
    {
        static int count;

        public static int increament() { count++;  return count; }
        public static int decreament() { count--;  return count; }
    }
}
