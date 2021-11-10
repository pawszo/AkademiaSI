using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class SwitchCase
    {
        void SwitchOnNumber()
        {
            int number = 10;

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("ONE");
                        break;
                    }
                    
                case 2: Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                default: Console.WriteLine("OTHER NUMBER");
                    break;
            }
            //
        }

        public void SwitchOnString()
        {
            string text = "ABC";

            switch(text)
            {
                case "ABC":
                    {
                        break;
                    }
            }
        }




    }
}
