using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var tryCatchExample = new TryCatchExample();
            tryCatchExample.TryCatchSimple();
            tryCatchExample.TryCatchAdvanced();

            var value = tryCatchExample.GetFromDictionary("ACAB");
        }
    }
}
