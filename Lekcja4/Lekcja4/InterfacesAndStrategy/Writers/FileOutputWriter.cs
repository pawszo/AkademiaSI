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

        private string _mainPath;
        private string _filename;
        private string text;

        public FileOutputWriter(FileService fileService)
        {
            _fileService = fileService;
            _debugFileName = "MYFILE.txt";
            _userFileName = "userfile.txt";
        }

        public void Debug(FileService fileService, string mainPath, string filename, string text)
        {
            _fileName = "Text";
            _exceptionFileName = "FileDebug.txt";
            _mainPath = "C:/";
            _text = text;

            try
            {
                _fileService.SaveToFile(_mainPath, _filename, _text);
            }
            catch (Exception e)
            {
                _fileService.SaveToFile(_mainPath, _filename, e.HResult);
            }
        }

        public void UserError(string mainPath, string filename, string text)
        {
            _fileName = "Text";
            _exceptionFileName = "UserError.txt";
            _mainPath = "C:/";
            _text = text;

            try
            {
                _fileService.SaveToFile(_mainPath, _filename, _text);
            }
            catch (Exception e)
            {
                _fileService.SaveToFile(_mainPath, _filename, e.Message);
            }
        }

        public void UserInfo(string mainPath, string filename, string text)
        {
            _fileName = "Text";
            _exceptionFileName = "UserInfo.txt";
            _mainPath = "C:/";
            _text = text;

            try
            {
                _fileService.SaveToFile(_mainPath, _filename, _text);
            }
            catch (Exception e)
            {
                _fileService.SaveToFile(_mainPath, _filename, e.StackTrace);
            }
        }

        public void UserWarning(string mainPath, string filename, string text)
        {
            _fileName = "Text";
            _exceptionFileName = "UserWarning.txt";
            _mainPath = "C:/";
            _text = text;
                
            try
            {
                _fileService.SaveToFile(_mainPath, _filename, _text);
            }
            catch(Exception e)
            {
                _fileService.SaveToFile(_mainPath, _filename, e.InnerException);
            }
        }
    }
}
