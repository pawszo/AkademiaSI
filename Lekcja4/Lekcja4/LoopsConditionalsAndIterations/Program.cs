using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConditionalsAndIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myObject = new IfStatement();

            //myObject.IfElseConditional();
            //Console.ReadKey();

            //var list = new List<string>();
            //var list2 = list as IEnumerable<string>;

            //var list3 = list2 as IList<string>;
            //var item = 1234;
            //var obj = new object();
            //list3.Add("element1");

            //var listsList = new List<IList<string>>();
            //listsList.Add(list);
            //listsList.Add(list2 as IList<string>);
            //listsList.Add(list3);

            //foreach(var collection in listsList)
            //{
            //    collection.Add("DUPA");
            //}



            //Console.WriteLine(list[0]);
            //Console.WriteLine(list2.First());
            //Console.WriteLine(list.First());
            //var loops = new Loops();
            //loops.ForLoopArray();

            var foreachExample = new Foreach();

            foreachExample.DoSomethingForEachElement();
            foreachExample.DoSomethingForEachElementIntegers();


        }


    }
}
