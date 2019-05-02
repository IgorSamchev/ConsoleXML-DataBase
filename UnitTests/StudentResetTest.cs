using System;
using System.Collections.Generic;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentResetTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            for (int i = 0; i < 10; i++) list.Add(new Student(1, "1", "1", 1, 1, 1, 1));
            int arraySizeBeforeReset = list.Count;

            list = StudentReset.DeleteAllAndPutFourDefaultStudents();
            int arraySizeAfterReset = list.Count;


            Assert.AreNotEqual(arraySizeBeforeReset, arraySizeAfterReset); //size decreased
            Assert.AreEqual(true, list[0].LastName.Equals("Ivanov")); //1-st is default Student Ivanov
            Assert.AreEqual(4, arraySizeAfterReset); //added 4 default Students
        }
    }
}