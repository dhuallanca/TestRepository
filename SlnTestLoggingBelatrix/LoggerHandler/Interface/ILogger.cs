using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerHandler.Interface
{
    public interface ILogger
    {
        void LogMessage(string message, LoggerBase.Severity severity, LoggerBase.LogTo logTo);

    }
}
