using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStrategy.Interfaces
{
    public interface IOutputWriter
    {
        void UserInfo(string message);
        void UserWarning(string message);
        void UserError(string message);
        void Debug(string message);

    }
}
