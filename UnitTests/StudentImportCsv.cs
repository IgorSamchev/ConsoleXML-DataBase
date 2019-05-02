using System.Collections.Generic;
using System.Linq;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentImportCsvTest
    {
        [TestMethod]
        public void ImportStudentsFromScvFile()
        {
            string path = "objstore\\export.csv";
            List<Student> actual = StudentImportCsv.ReadFromCsv(path);

            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
                new Student(2, "Sidorov", "B", 1985, 5, 4, 3),
                new Student(3, "Smith", "B", 1989, 2, 4, 3)
            };
            //Check that old Students replaced to new Students from expected list
            Assert.AreEqual(expected.Count, actual.Count());
            Assert.AreEqual(expected[0].LastName, actual[0].LastName);
            Assert.AreEqual(expected[1].Id, actual[1].Id);
            Assert.AreEqual(expected[2].Year, actual[2].Year);
            Assert.AreEqual(expected[3].Informatics, actual[3].Informatics);
        }
    }
}