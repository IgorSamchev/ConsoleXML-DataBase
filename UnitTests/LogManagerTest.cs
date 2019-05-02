using System.IO;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class LogManagerTest
    {
        [TestMethod]
        public void LogTest()
        {
            string testMessage = "This is test message";
            LogManager.WriteLog(testMessage);

            string[] lines = File.ReadAllLines("objstore\\objstore.log");

            string expectedResult = "This is test message";
            string actualResult = lines[lines.Length - 1]; // Check that last added line is testMessage
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}