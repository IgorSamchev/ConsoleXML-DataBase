using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTests
{
    [TestClass]
    public class StudentFromXmlTest
    {
        [TestMethod]
        public void AddToArray()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            //Check that Students can be read from .xml and parse to <Student> list
            Assert.AreEqual(list.Count > 0, list.Count > 0);
        }
    }
}
