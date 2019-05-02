using System.Collections.Generic;
using System.IO;
using System.Linq;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentToCsvTest
    {
        [TestMethod]
        public void WriteToCsv()
        {
            string path = "objstore";
            List<Student> students = StudentFromXml.ReadStudentsFromXml();
            StudentToCsv.WriteToCsv(students, path);

            string[] expected =
            {
                "0,Ivanov,A,1987,5,4,3",
                "1,Petrov,A,1989,3,4,5",
                "2,Sidorov,B,1985,5,4,3",
                "3,Smith,B,1989,2,4,3"
            };
            string[] actual = File.ReadAllLines("objstore\\export.csv");

            Assert.AreEqual(true, expected.SequenceEqual(actual)); // 4 lines
        }
    }
}