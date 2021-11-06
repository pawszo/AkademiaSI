using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class Foreach
    {
        void DoSomethingForEachElement()
        {
            string[] elements = new string[] { "raz", "dwa", "trzy" };

            foreach(string element in elements)
            {
                Console.WriteLine(element);
            }

        }


    }
}
