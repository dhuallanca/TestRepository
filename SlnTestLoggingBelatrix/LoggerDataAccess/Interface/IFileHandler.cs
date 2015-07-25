using System;

namespace LoggerDataAccess.Interface
{
    public interface IFileHandler
    {
        void WriteMessage(string message, string logType);
    }
}
