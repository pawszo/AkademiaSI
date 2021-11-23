using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfacesAndStrategy.Services
{
    public class PrintService
    {
        public void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }
}