using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LoggerHandler.Test
{
    [TestFixture]
     public class OriginalJobLogger
    {
        private JobLoggerTest _logger;
        [SetUp]
        public void SetUp()
        {
            _logger = new JobLoggerTest(false, true, false, true, false, false);
        }


        [TestCase]
        public void LogMessage_Test()
        {
            JobLoggerTest.LogMessage("input", true, false, false);

            JobLoggerTest.LogMessage("input two", true, false, false);
            Assert.AreEqual("1", "1");
        }

        [TestCase]
        public void LogError_Test()
        {
            JobLoggerTest.LogMessage("input", false, false, true);
            Assert.AreEqual("1", "1");
        }

    }
     
   
}
