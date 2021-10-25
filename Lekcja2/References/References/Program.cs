using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValueTypes.PassingValueTypeToMethod();
            ReferenceTypes.PassingReferenceTypeToMethod();

            ConsoleWaitForUserKey();
        }

        private static void ConsoleWaitForUserKey()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any key to close the console.");
            Console.ReadKey();
        }

        private static void Test()
        {
            
        }
    }
}
