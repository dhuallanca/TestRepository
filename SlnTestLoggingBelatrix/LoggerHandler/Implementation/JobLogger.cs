using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggerDataAccess.Implementation;
using LoggerDataAccess.Interface;
using LoggerHandler.Interface;

namespace LoggerHandler.Implementation
{
    public class JobLogger : LoggerBase, ILogger
    {

        private readonly ILogDataAccess _logDataAccess;
        private readonly IFileHandler _fileHandler;

        public JobLogger()
        {
            _logDataAccess = new LogDataAccess();
            _fileHandler = new FileHandler();
        }

        //public JobLogger(IConfig config, int skipFrames)
        //{
        //    _pageName = config.SessionContext.PageName;
        //    _aspSessionId = config.SessionContext.AspSessionId;
        //    _sessionId = config.SessionContext.SessionId;
        //    _clientIp = config.SessionContext.ClientIp;

        //    _syslog = GetLogger(config, skipFrames);
        //}


        protected override void WriteOutput(string message, Severity severity, LogTo logTo)
        {
           
            if (logTo.HasFlag(LogTo.File))
            {
                _fileHandler.WriteMessage(message, severity.ToString());
            }
            if (logTo.HasFlag(LogTo.DataBase))
            {
                _logDataAccess.InsertMessage(message, (int) severity);
            }
            if (logTo.HasFlag(LogTo.Console))
            {
                //TODO:implements console
                switch(severity)
                {
                    case Severity.Message:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Severity.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Severity.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                    
                Console.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), message);
            }
        }

       
    }
}
