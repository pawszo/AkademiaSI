using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class ValueTypes
    {
        public static void PassingValueTypeToMethod()
        {
            var number = 5;
            IncreaseNumber(number);
            Console.ReadKey();
            Console.WriteLine(number); // PRINTS 5
            // THAT IS BECAUSE THE VALUE IS COPIED TO THE METHOD, BUT THE VALUE THAT *number* VARIABLE
            // POINTS TO IS NOT AMENDED

        }

        private static void IncreaseNumber(int number)
        {
            number = number * 10;
            Console.ReadKey();
            Console.WriteLine(number); // PRINTS 50
        }

    }
}
