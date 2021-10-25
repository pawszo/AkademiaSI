using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringOperationsExamples.Trimming();
            //StringOperationsExamples.CaseSwapping();
            //StringOperationsExamples.Equals();
            //StringOperationsExamples.Splitting();
            //StringOperationsExamples.RegexSplitting();
            //StringOperationsExamples.Joining();
            //StringOperationsExamples.EqualsIgnoreCaseAndCulture();
            StringOperationsExamples.Concatenation();

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
