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
        private readonly PrintService _printService;

        public FileOutputWriter(PrintService fileService)
        {
            _printService = printService;

        }

        public void Debug(string text)
        {
            try
            {
                _printService.PrintText(text)
            }
            catch (Exception e)
            {
                _printService.PrintText(e.HResult);
            }
        }

        public void UserError(string text)
        {
            try
            {
                _printService.PrintText(text)
            }
            catch (Exception e)
            {
                _printService.PrintText(e.Message);
            }
        }

        public void UserInfo(string text)
        {
            try
            {
                _printService.PrintText(text)
            }
            catch (Exception e)
            {
                _printService.PrintText(e.StackTrace);
            }
        }

        public void UserWarning(string text)
        {
            try
            {
                _printService.PrintText(text)
            }
            catch (Exception e)
            {
                _printService.PrintText(e.InnerException);
            }
        }
    }
