using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace StringOperations
{
    class StringOperationsExamples
    {
        public static void Trimming()
        {
            var untrimmed = " Ala ma kota. ";

            Console.WriteLine(untrimmed);
            Console.ReadKey();

            var trimmed = untrimmed.Trim();
            

            Console.WriteLine(trimmed);
        }

        public static void CaseSwapping()
        {
            var text = "AbCdEfGhIj";
            Console.WriteLine(text);
            Console.ReadKey();

            text = text.ToLower();
            Console.WriteLine(text);
            Console.ReadKey();

            Console.WriteLine(text.ToUpper());
            Console.ReadKey();
        }

        public static void Concatenation()
        {
            var sum = 'a' + 'b' + 'c'; // WRONG! This returns INT that is sum of adding numering values of characters
            var concat1 = string.Format("{0}{1}{2}", 'a', 'b', 'c'); // CORRECT! This returns string "abc"
            var concat2 = $"{'a'}{'b'}{'c'}"; // CORRECT! This returns string "abc"
            var concat3 = "a" + "b" + "c"; // CORRECT BUT UGLY! This returns string "abc"
            var concat4 = 'a'.ToString() + 'b'.ToString() + 'c'.ToString(); // CORRECT BUT UGLY! This returns string "abc"
            Console.WriteLine(sum);
            Console.WriteLine(concat1);
            Console.WriteLine(concat2);
            Console.WriteLine(concat3);
            Console.WriteLine(concat4);
        }

        public static void EqualsIgnoreCaseAndCulture()
        {
            string text1 = "bær";
            string text2 = "BAER";
            bool areEqualAsTheyAre = text1.Equals(text2); //FALSE
            Console.WriteLine($"areEqualAsTheyAre: {areEqualAsTheyAre}");

            bool areEqualIgnoreCase = text1.Equals(text2, StringComparison.OrdinalIgnoreCase); //FALSE
            Console.WriteLine($"areEqualInCommonCase: {areEqualIgnoreCase}");

            bool AreEqualIgnoreCaseWithInvariantCulture = text1.Equals(text2, StringComparison.InvariantCultureIgnoreCase); //TRUE
            Console.WriteLine($"AreEqualInCommonCaseWithInvariantCulture: {AreEqualIgnoreCaseWithInvariantCulture}");


        }

        public static void Splitting()
        {
            var sentence = "Litwo\tojczyzno  moja\nty \0jestes jak zdrowie";

            var words = sentence.Split(' ', '\t', '\n', '\0');

            foreach(string a in words)
            {
                Console.WriteLine(a);
                Console.ReadKey();
            }
            Console.ReadKey();

        }

        public static void RegexSplitting()
        {
            var sentence = "Litwo                        ojczyzno\tmoja            ty\n\njestes jak\rzdrowie";


            var words = Regex.Split(sentence, @"\s+");
            words.ToList().ForEach(p => Console.WriteLine(p));
            Console.ReadKey();
        }

        public static void Joining()
        {
            var words = new string[] { "Ala", "ma", "kota" };

            var sentence = string.Join(" ", words);
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
