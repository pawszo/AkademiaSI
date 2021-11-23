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

        private string _mainPath;
        private string _fileName;

        public void Debug(string message)
        {
            _mainPath = "C:/";
            _fileName = "Debug.txt";
            message = "e";

            _fileService.SaveToFile(_mainPath, _fileName, message);

        }

        public void UserError(string message)
        {
            _mainPath = "C:/";
            _fileName = "UserError.txt";
            message = "f";

            _fileService.SaveToFile(_mainPath, _fileName, message);
        }

        public void UserInfo(string message)
        {
            _mainPath = "C:/";
            _fileName = "UserInfo.txt";
            message = "g";

            _fileService.SaveToFile(_mainPath, _fileName, message);
        }

        public void UserWarning(string message)
        {
            _mainPath = "C:/";
            _fileName = "UserWarning.txt";
            message = "h";

            _fileService.SaveToFile(_mainPath, _fileName, message);
        }
    }
}