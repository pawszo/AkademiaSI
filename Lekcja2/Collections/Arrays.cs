using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Arrays
    {
        public static void DeclaringArrays()
        {
            string[] arrayStaticallyDeclared = new string[3];
            arrayStaticallyDeclared[0] = "ALA";
            arrayStaticallyDeclared[1] = "MA";
            arrayStaticallyDeclared[2] = "KOTA";

            string[] arrayDynamicallyDeclared = new string[] { "ALA", "MA", "KOTA" };

            Console.WriteLine(arrayStaticallyDeclared.Length);
            Console.WriteLine(arrayDynamicallyDeclared.Length);
        }

        public static void ComparingArrays()
        {
            string[] arrayStaticallyDeclared = new string[3];
            arrayStaticallyDeclared[0] = "ALA";
            arrayStaticallyDeclared[1] = "MA";
            arrayStaticallyDeclared[2] = "KOTA";

            string[] arrayDynamicallyDeclared = new string[] { "ALA", "MA", "KOTA" };

            bool standardComparison = arrayDynamicallyDeclared.Equals(arrayStaticallyDeclared); //RETURNS FALSE - ELEMENTS ARE EQUAL BUT ARRAY OBJECTS ARE DIFFERENT INSTANCES!
            Console.WriteLine($"standardComparison: {standardComparison}"); 
            bool comparisonUsingEnumerableHelperMethod = Enumerable.SequenceEqual(arrayDynamicallyDeclared, arrayStaticallyDeclared); //RETURNS TRUE AS THE METHOD COMPARES THE ELEMENTS INSIDE
            Console.WriteLine($"comparisonUsingEnumerableHelperMethod: {comparisonUsingEnumerableHelperMethod}"); 
        }

        public static void AddingElements()
        {
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            foreach(var element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }

        public static void SortingByLength()
        {
            var array = new string[] { "Ala", "ma", "kota" };
            array.ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadKey();

            array.OrderBy(p => p.Length).ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadKey();
        }

        public static void CustomSortingByLength()
        {
            var array = new string[] { "Ala", "ma", "kota" };
            array.ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadKey(); 

            Array.Sort(array, CompareByLength);
            array.ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadKey();
        }

        private static int CompareByLength(string a, string b)
        {
            if (a.Length > b.Length) return 1;
            if (a.Length < b.Length) return -1;
            else return 0;
        }

        


        
    }
}
