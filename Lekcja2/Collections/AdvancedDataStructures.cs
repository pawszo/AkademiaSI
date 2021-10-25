using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class AdvancedDataStructures
    {
        public static void NonGenericArrayList()
        {
            var nonGenericList = new ArrayList();
            nonGenericList.Add(2);
            nonGenericList.Add("DUPA");
            nonGenericList.Add(15.3d);
            nonGenericList.Add(new int[5]);
            


            foreach(var element in nonGenericList)
            {
              /*  if(element is string)
                {
                    (element as string).Replace()
                }
                if(element is int)
                {
                    ((int) element).
                }
              */
            }
            Console.ReadKey();
        }

        public static void GenericList()
        {
            var genericList = new List<string>();
            genericList.Add("Ala ma kota");
            genericList.Add("All cops are bastards");
            genericList.Add("Żeli papą");

            foreach(var elem in genericList)
            {
                elem.Split(new char[] { ' ' }).ToList().ForEach(p => Console.WriteLine(p));
            }
        }

        public static void Queue()
        {
            var ticketQueue = new Queue<string>();
            var ticketStack = new Stack();

            ticketQueue.Enqueue("Zgloszenie nr 1");
            ticketQueue.Enqueue("Zgloszenie nr 2");
            ticketQueue.Enqueue("Zgloszenie nr 3");

            while(ticketQueue.Count > 0)
            {
                Console.WriteLine($"Number of remaining tickets: {ticketQueue.Count}");
                Console.WriteLine("Press any key to draw a ticket");
                Console.ReadKey();
                Console.WriteLine(ticketQueue.Dequeue());
            }

            Console.WriteLine($"Number of remaining tickets: {ticketQueue.Count}");
        }

        public static void Dictionary()
        {
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "ALA");
            dictionary.Add(1, "ALA");
            dictionary.Add(3, "KOTA");
            dictionary[1] = "ABC";

            int i = 1;
            while(i <= 3)
            {
                Console.WriteLine(dictionary[i++]);
                Console.ReadKey();
            }
            
        }
    }
}
