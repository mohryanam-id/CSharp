using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class StringIndexerType
    {
        private string[] strArray = new string[10];
        public string this[int index]
        { get { return strArray[index]; } set { strArray[index] = value;} }
    }
}
