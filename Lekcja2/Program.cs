using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia
{
    class Program   
    {
        static void Main(string[] args)
        {

            var myCar = new Car("BMW");
            myCar.Price = 200000m;
            var hisCar = new Car("FIAT");
            // myCar.StartEngine();
            //hisCar.StartEngine();
            Car.DoSomething();
            var motor = new Motorbike();
            
            
            var enginableList = new List<IEnginable>();
            enginableList.Add(motor);
            enginableList.Add(myCar);
            enginableList.Add(hisCar);

            var jednoslady = new List<IJednoslad>();
            jednoslady.Add(motor);



            foreach(var item in enginableList)
            {
                item.StartEngine();
                
            }

            foreach (var item in jednoslady)
            {
                if (item is Motorbike) (item as Motorbike).StartEngine();

            }


            ConsoleWaitForUserKey();

        }

        private static void ConsoleWaitForUserKey()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any key to close the console.");
            Console.ReadKey();
        }
    }
}
