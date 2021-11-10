using InterfacesAndStrategy.Interfaces;
using InterfacesAndStrategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStrategy.Writers
{
    public class FileOutputWriter : IOutputWriter
    {
        private readonly FileService _fileService;
        private string _debugFileName;
        private string _userFileName;

        public FileOutputWriter(FileService fileService)
        {
            _fileService = fileService;
            _debugFileName = "MYFILE.txt";
            _userFileName = "userfile.txt";
        }

        public void Debug(string message)
        {
            _fileService.SaveToFile(_debugFileName, message);
        }

        public void UserError(string message)
        {
            _fileService.SaveToFile(_userFileName, message);
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
