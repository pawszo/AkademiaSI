using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TryCatchExample
    {

        public void TryCatchSimple()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("dupa", "glowa");

            //if (dictionary.TryGetValue("dupa", out string value))
            //{
            //    Console.WriteLine(value);
            //}

            try
            {
                string value = dictionary["noga"];
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is wrong");
                Console.WriteLine(e.StackTrace);
            }


        }

        public void TryCatchAdvanced()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("dupa", "glowa");

            //if (dictionary.TryGetValue("dupa", out string value))
            //{
            //    Console.WriteLine(value);
            //}

            try
            {
                string value = dictionary["noga"];
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("This key is null");
                Console.WriteLine(e.StackTrace);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("This key does not exist");
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("AJSNADJ");
        }

        public string GetFromDictionary(string key)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("dupa", "glowa");

            //if (dictionary.TryGetValue("dupa", out string value))
            //{
            //    Console.WriteLine(value);
            //}

            try
            {
                string value = dictionary[key];
                return value;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("This key is null");
                Console.WriteLine(e.StackTrace);
                return null;
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("This key does not exist");
                Console.WriteLine(e.StackTrace);
                //finally
                return null;
            }
            finally
            {
                Console.WriteLine("FINALLY BLOCK IS EXECUTED");
            }

        }
    }
}
