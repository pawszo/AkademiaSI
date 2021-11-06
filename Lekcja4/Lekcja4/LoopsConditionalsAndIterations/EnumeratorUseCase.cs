using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class EnumeratorUseCase
    {
        void UseEnumeratorToKeepTrackOf2Elements()
        {
            var checkList = new List<string> { "cat", "dog", "cow" };

            using (var enumerator1 = checkList.GetEnumerator())
            {
                var enumerator2 = checkList.GetEnumerator();
                
                Console.WriteLine(enumerator1.Current); //initially ienumerator points to null 

                enumerator2.MoveNext(); //MoveNext() sets the next (first) collection element to Current property
                Console.WriteLine(enumerator2.Current);

                while (enumerator1.MoveNext()) //MoveNext() return true if next element exists so it can be used as expression
                {
                    Console.WriteLine(enumerator1.Current);
                    
                    
                    if(enumerator2.MoveNext())
                    {
                        Console.WriteLine(enumerator2.Current);
                    }

                }

                enumerator2.Dispose(); // ienumerator must be disposed to free the memory - otherwise it will not be collected by garbage collector

            }//enumerator1 doesnt need to be disposed as using( ){ } block takes care of it
                

            
        }
    }
}
