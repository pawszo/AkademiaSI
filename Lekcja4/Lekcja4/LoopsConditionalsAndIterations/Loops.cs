using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class Loops
    {
        void WhileLoop()
        {
            int i = 0;
            while(i < 20)
            {
                // DO SOMETHING
                i++;
            }
        }

        void InfiniteWhileLoop()
        {
            bool isLoopExitTriggered = false;
            while(true)
            {
                // DO SOMETHING

                if (isLoopExitTriggered) break;

                System.Threading.Thread.Sleep(1000);
            }
        }

        void DoWhile()
        {
            do
            {
                //do some stuff
            }
            while (0 != 0);
        }

        public void ForLoopArray()
        {
            string[] array = new string[] { "ACAB", "ABC", "CBA" };

            for(int i = 0; i < array.Length; i++)
            {
                string item = array[i];
                Console.WriteLine(item);
            }
        }


        void ForLoop()
        {
            for(int i = 0; i < 10; i++)
            {
                // do stuff
            }
        }

        void ForLoopVariation1()
        {
            for(int i = 10, j = 1; i > j; i++, j += 2)
            {
                // do stuff
            }
        }

        void ForLoopVariation2()
        {
            bool isLoopExitTriggered = false;
            for (;true;) // == while(true)
            {
                //INFINITE LOOP!!!

                if (isLoopExitTriggered) break;
            }
        }

        void ForLoopVariation3()
        {
            for (int i = 0; i++ < 10; Console.WriteLine(i) ) ;
        }

        void ForLoopVariation4()
        {
            for (int i = 0; i++ < 10;)
            {
                // do stuff
                i++;
            }
        }
    }
}
