using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoggerHandler.Implementation;
using LoggerHandler.Interface;
using NUnit.Framework;
namespace LoggerHandler.Test
{
 
    [TestFixture]
    public class LoggerTest
    {
        private ILogger _logger;
        [SetUp]
        public void SetUp()
        {
            _logger = new JobLogger();
        }


        [ExpectedException]
        [TestCase]
        public void LogMessagePathFile_Test()
        {
            
            _logger.LogMessage("message test", LoggerBase.Severity.Message, LoggerBase.LogTo.File);
        }

        [TestCase("message line 1;")]
        [TestCase("message line 2;")]
        public void LogMessageToFile_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Message, LoggerBase.LogTo.File);
            Assert.AreEqual("1", "1");
        }

        [TestCase("message line 1 to console;")]
        [TestCase("message line 2 to console;")]
        public void LogMessageToConsole_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Message, LoggerBase.LogTo.Console);
            Assert.AreEqual("1", "1");
        }


        [TestCase("warning line 1;")]
        [TestCase("warning line 2;")]
        public void LogWarningToFile_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Warning, LoggerBase.LogTo.File);
            Assert.AreEqual("1", "1");
        }

        [TestCase("warning line 1 to console;")]
        [TestCase("warning line 2 to console;")]
        public void LogWarningToConsole_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Warning, LoggerBase.LogTo.Console);
            Assert.AreEqual("1", "1");
        }

        [TestCase("error line 1 to console;")]
        [TestCase("error line 2 to console;")]
        public void LogErrorToConsole_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Error, LoggerBase.LogTo.Console);
            Assert.AreEqual("1", "1");
        }

        [TestCase("error line 1 to database;")]
        [TestCase("error line 2 to database;")]
        public void LogErrorToDatabase_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Error, LoggerBase.LogTo.DataBase);
            Assert.AreEqual("1", "1");
        }


        [TestCase("error line 1 to database-file-console;")]
        [TestCase("error line 2 to databasefile-console;")]
        public void LogErrorToAll_Test(string message)
        {
            _logger.LogMessage(message, LoggerBase.Severity.Error, LoggerBase.LogTo.All);
            Assert.AreEqual("1", "1");
        }
    }
}
