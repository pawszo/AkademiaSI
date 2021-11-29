using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfacesAndStrategy.Services
{
    public class FileService
    {
        public void SaveToFile(string mainPath, string fileName, string text)
        {
            string _mainPath = mainPath;
            string _fileName = fileName;
            string _fullPath = Path.Combine(_mainPath, _fileName);

            using (StreamWriter pisz = new StreamWriter(_fullPath))
            {
                pisz.WriteLine(text);
            }
        }
    }
}