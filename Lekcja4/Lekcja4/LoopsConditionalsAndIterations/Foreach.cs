using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    public class Foreach
    {
        public void DoSomethingForEachElement()
        {
            var elements = new string [] { "raz", "dwa", "trzy" }.ToList();
            var itemsToRemove = new List<string>();

            foreach(string element in elements)
            {
                Console.WriteLine(element);
                if (element.Length > 3)
                {
                    itemsToRemove.Add(element);
                    //elements.Remove(element); // WILL NOT WORK
                }
            }

            foreach(var itemToRemove in itemsToRemove)
            {
                elements.Remove(itemToRemove);
            }

        }

        public void DoSomethingForEachElementIntegers()
        {
            var elements = new int[] { 1, 2, 3 }.ToList();
            var itemsToRemove = new List<int>();

            foreach (int element in elements)
            {
                Console.WriteLine(element);
                if (element >= 3)
                {
                    itemsToRemove.Add(element);
                    //elements.Remove(element); // WILL NOT WORK
                }
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                elements.Remove(itemToRemove);
            }

        }
    }
}
