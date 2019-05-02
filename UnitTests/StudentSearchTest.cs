using System.Collections.Generic;
using System.Linq;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentSearchTest
    {
        private readonly List<Student> _students = StudentFromXml.ReadStudentsFromXml();

        private static bool Compare(List<Student> filteredList, List<Student> expected)
        {
            //if list is null, Compare can not be done
            if (filteredList == null || expected == null)
            {
                return false;
            }

            //if lists have different size -> false
            if (filteredList.Count != expected.Count)
            {
                return false;
            }

            return !filteredList.Where((student, i) => !student.Id.Equals(expected[i].Id)).Any();
        }

        /*Default Students

         * new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
           new Student(1, "Petrov", "A", 1989, 3, 4, 5),
           new Student(2, "Sidorov", "B", 1985, 5, 4, 3),
           new Student(3, "Smith", "B", 1989, 2, 4, 3)
         */

        [TestMethod]
        public void SearchByIdTest()
        {
            const string data = "3";
            List<Student> filteredList = StudentSearch.SearchById(_students, data);
            List<Student> expected = new List<Student>
                {new Student(3, "Smith", "B", 1989, 2, 4, 3)};

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByLastNameTest()
        {
            const string data = "ov";
            List<Student> filteredList = StudentSearch.SearchByLastName(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
                new Student(2, "Sidorov", "B", 1987, 5, 4, 3)
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByGroupTest()
        {
            const string data = "A";
            List<Student> filteredList = StudentSearch.SearchByGroup(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByYearTest()
        {
            const string data = "1989";
            List<Student> filteredList = StudentSearch.SearchByYear(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
                new Student(3, "Smith", "B", 1989, 2, 4, 3)
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByYearPhysicsTest()
        {
            const string data = "5";
            List<Student> filteredList = StudentSearch.SearchByPhysicsScore(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(2, "Sidorov", "B", 1985, 5, 4, 3)
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByYearMathTest()
        {
            const string data = "4";
            List<Student> filteredList = StudentSearch.SearchByMathScore(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
                new Student(2, "Sidorov", "B", 1985, 5, 4, 3),
                new Student(3, "Smith", "B", 1989, 2, 4, 3)
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }

        [TestMethod]
        public void SearchByYearInformaticsTest()
        {
            const string data = "3";
            List<Student> filteredList = StudentSearch.SearchByInformaticsScore(_students, data);
            List<Student> expected = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(2, "Sidorov", "B", 1985, 5, 4, 3),
                new Student(3, "Smith", "B", 1989, 2, 4, 3)
            };

            bool compare2Arrays = Compare(filteredList, expected);

            Assert.AreEqual(true, compare2Arrays);
        }
    }
}