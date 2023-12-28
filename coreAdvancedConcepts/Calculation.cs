using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreAdvancedConcepts
{
    [Obsolete]
    internal class Calculation
    {
        public void Calculate()
        {
            int a, b, result=0;
            try
            {
                a = int.Parse(s: Console.ReadLine());
                b = int.Parse(s: Console.ReadLine());
                result = a / b;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
                Console.WriteLine(e.StackTrace);
            }
            finally { Console.WriteLine(result); }
        }
    }
}
