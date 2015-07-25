using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerHandler.Interface
{
    public interface ILoggerHandler
    {
        void File(string message, LoggerBase.Severity severity);

        void Console(string message, LoggerBase.Severity severity);

        void Database(string message, LoggerBase.Severity severity);
    }
}
