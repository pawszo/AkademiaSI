using InterfacesAndStrategy.Interfaces;
using InterfacesAndStrategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStrategy.Writers
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        private readonly PrintService _printService;

        public void Debug(string message)
        {
            message = "a";

            _printService.PrintText($"Debug info:" + message);
        }

        public void UserError(string message)
        {
            message = "b";

            _printService.PrintText($"User error:" + message);
        }

        public void UserInfo(string message)
        {
            message = "c";

            _printService.PrintText($"User info:" + message);
        }

        public void UserWarning(string message)
        {
            message = "d";

            _printService.PrintText($"User warning:" + message);
        }
    }
}