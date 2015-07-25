using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggerHandler.Interface;

namespace LoggerHandler.Implementation
{
    public class LoggerHandler:ILoggerHandler
    {
        public void File(string message, LoggerBase.Severity severity)
        {
            throw new NotImplementedException();
        }

        public void Console(string message, LoggerBase.Severity severity)
        {
            throw new NotImplementedException();
        }

        public void Database(string message, LoggerBase.Severity severity)
        {
            throw new NotImplementedException();
        }
    }
}
