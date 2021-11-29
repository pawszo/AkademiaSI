using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesAndStrategy.Writers;
using InterfacesAndStrategy.Interfaces;

namespace InterfacesAndStrategy.Triggers
{
    public class Run
    {
        private readonly ConsoleOutputWriter _pisz;

        string text = "aaa";
        public void DoIt()
        {
            _pisz.Debug(text);
        }
    }
}