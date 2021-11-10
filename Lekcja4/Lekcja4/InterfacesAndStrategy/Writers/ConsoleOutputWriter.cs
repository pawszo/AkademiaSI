using InterfacesAndStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStrategy.Writers
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void UserError(string message)
        {
            throw new NotImplementedException();
        }

        public void UserInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void UserWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
