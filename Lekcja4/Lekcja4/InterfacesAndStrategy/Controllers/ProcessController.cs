using InterfacesAndStrategy.Interfaces;
using InterfacesAndStrategy.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStrategy.Controllers
{
    public class ProcessController
    {
        private readonly IOutputWriter _outputWriter;

        public ProcessController(IOutputWriter outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public void Process()
        {
            try
            {
                // do something


                _outputWriter.UserInfo("ALL GOOD");
            }
            catch(Exception e)
            {
                _outputWriter.Debug(e.StackTrace);
            }
        }
    }
}
