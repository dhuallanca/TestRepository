using LoggerDataAccess.Interface;
using System;
using System.IO;
using System.Text;

namespace LoggerDataAccess.Implementation
{
    public class FileHandler : IFileHandler
    {

        private readonly string _path;
        public FileHandler()
        {
            _path = string.Format(@"{0}{1}{2}.txt", System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"], "LogFile", DateTime.Now.ToString("yyyy-MM-dd"));
        }
        public void WriteMessage(string message, string logType)
        {
            var l = string.Empty;
            l = string.Format(@"Log Type:{0}, [{1}-{2}-{3}] {4}", logType, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, message);

            var info = new UTF8Encoding(true).GetBytes(l);

            if (!System.IO.File.Exists(_path))
            {
                // Create the file. 
                using (var fs = File.Create(_path))
                {
                    // Add message.
                    fs.Write(info, 0, info.Length);
                }
            }
            else
            {
                using (var strw = new StreamWriter(_path, true))
                {
                    strw.WriteLine(l);
                }
            }
            

        }
    }
}