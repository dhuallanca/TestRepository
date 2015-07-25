using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggerHandler
{
    public abstract class LoggerBase
    {
     
        public void LogMessage(string message, LoggerBase.Severity severity, LogTo logTo)
        {
            try
            {
                this.WriteOutput(message, severity, logTo);
            }
            catch(Exception ex)
            {
                this.WriteOutput(ex.Message, Severity.Error, logTo);
            }
        }


        protected abstract void WriteOutput(string message, LoggerBase.Severity severity, LogTo logTo);

  
        public enum Severity
        {
            Message,
            Error,
            Warning,
        }

        [Flags]
        public enum LogTo
        {
            File = 1,
            Console = 2,
            DataBase = 4,
            All = 7
        }
    }
}
