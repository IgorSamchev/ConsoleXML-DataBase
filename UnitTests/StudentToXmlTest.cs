using System.Collections.Generic;
using System.IO;
using System.Linq;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentToXmlTest
    {
        [TestMethod]
        public void InsertNewStudent()
        {
            Student student = new Student(333, "LastName", "KTA-18V", 1999, 5, 5, 5);
            IEnumerable<string> list = File.ReadLines("objstore\\students.xml");
            int linesBeforeAdding = list.Count();

            List<Student> students = StudentFromXml.ReadStudentsFromXml();
            students.Add(student);

            StudentToXml.StudentsToXml(students);

            IEnumerable<string> list2 = File.ReadLines("objstore\\students.xml");
            int linesAfterAdding = list2.Count();

            Assert.AreEqual(linesBeforeAdding, linesAfterAdding - 9); // added 9 lines with data and element names
        }
    }
}