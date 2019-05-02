using System;
using System.Collections.Generic;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentInsertTest
    {
        [TestMethod]
        public void NewStudentCorrectlyAdded()
        {
            List<Student> listBefore = StudentFromXml.ReadStudentsFromXml();
            listBefore.Add(new Student(StudentInsert.GenerateNextId(), "Test", "KTA-18V", 1999, 5,5,5));
            StudentToXml.StudentsToXml(listBefore);

            List<Student> listAfter = StudentFromXml.ReadStudentsFromXml();
            
            //check that new Student added to .xml and without exception
            Assert.AreEqual(listBefore.Count, listAfter.Count);
        }
    }
}
