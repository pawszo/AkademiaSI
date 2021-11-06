using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class IfStatement
    {
        void IfConditional()
        {
            if(DateTime.Now.Hour > 19)
            {
                Console.WriteLine("KIDS MUST GO TO SLEEP NOW");
            }
        }

        void IfElseConditional()
        {
            var random = new Random();
            int randomNumber = random.Next();

            if(randomNumber % 2 == 0)
            {
                Console.WriteLine("The random number is even.");
            }
            else
            {
                Console.WriteLine("The random number is odd");
            }
        }

        void IfIfElseElseConditional()
        {
            var random = new Random();
            int randomNumber = random.Next();
            int threshold = 10;

            if(randomNumber > threshold)
            {
                Console.WriteLine($"Random number is greater than {threshold}");
            }
            else if(randomNumber == threshold)
            {
                Console.WriteLine($"Random number equals {threshold}");
            }
            else
            {
                Console.WriteLine($"Random number is less than {threshold}");
            }
        }

        
    }
}
