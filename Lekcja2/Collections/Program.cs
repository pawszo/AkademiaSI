using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.DeclaringArrays();
            Arrays.ComparingArrays();
            //Arrays.AddingElements();
            //Arrays.SortingByLength();
            //Arrays.CustomSortingByLength();
            //Arrays.Test();

            //AdvancedCollections.NonGenericArrayList();
            //AdvancedCollections.GenericList();
            //AdvancedDataStructures.Queue();
            //AdvancedDataStructures.Dictionary();

            ConsoleWaitForUserKey();
        }

        private static void ConsoleWaitForUserKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any key to close the console.");
            Console.ReadKey();
        }
    }
}
