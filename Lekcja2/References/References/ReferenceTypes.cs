using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class NumberHolder
    {
        public int Number;
    }

    class ReferenceTypes
    {
        public static void PassingReferenceTypeToMethod()
        {
            var number = new NumberHolder();
            number.Number = 5;
            IncreaseNumber(number);
            Console.ReadKey();
            Console.WriteLine(number.Number); // PRINTS 50
            // THAT IS BECAUSE THE REFERENCE TO THE *number* OBJECT IS PASSED TO THE METHOD
            // THE METHOD AMENDS A MEMBER OF THE OBJECT WHICH IN MEMORY IS STILL THE SAME OBJECT NO MATTER WHERE
            // YOU ACCESS IT

        }

        private static void IncreaseNumber(NumberHolder number)
        {
            number.Number = number.Number * 10;
            Console.ReadKey();
            Console.WriteLine(number.Number); // PRINTS 50
        }


    }
}
