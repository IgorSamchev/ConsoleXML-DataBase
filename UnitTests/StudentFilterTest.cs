using System;
using System.Collections.Generic;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.String;

namespace UnitTests
{
    [TestClass]
    public class StudentFilterTest
    {
        List<Student> _students = StudentFromXml.ReadStudentsFromXml();

        [TestMethod]
        public void FilterByIdInc()
        {
            _students = StudentFilters.FilterByIdInc(_students);
            int minId = _students[0].Id;
            foreach (Student student in _students)
            {
                if (student.Id < minId) minId = student.Id;
            }
            // check that 1-st student in list now have min ID
            Assert.AreEqual(minId, _students[0].Id);
        }

        [TestMethod]
        public void FilterByIdDes()
        {
            _students = StudentFilters.FilterByIdDes(_students);
            int maxId = _students[0].Id;
            foreach (Student student in _students)
            {
                if (student.Id > maxId) maxId = student.Id;
            }
            // check that 1-st student in list now have max ID
            Assert.AreEqual(maxId, _students[0].Id);
        }

        [TestMethod]
        public void FilterByLastNameInc()
        {
            _students = StudentFilters.FilterByNameInc(_students);
            string minLastName = _students[1].LastName;
            foreach (Student student in _students)
            {
                if (Compare(student.LastName, minLastName, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    minLastName = student.LastName;
                }
            }
            // check that 1-st student in list now have min lastName (A < B < C < D etc)
            Assert.AreEqual(minLastName, _students[0].LastName);
        }

        [TestMethod]
        public void FilterByLastNameDes()
        {
            _students = StudentFilters.FilterByNameDes(_students);
            string maxLastName = _students[1].LastName;
            foreach (Student student in _students)
            {
                if (Compare(student.LastName, maxLastName, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    maxLastName = student.LastName;
                }
            }
            // check that 1-st student in list now have max lastName (A < B < C < D etc)
            Assert.AreEqual(maxLastName, _students[0].LastName);
        }

        [TestMethod]
        public void FilterByGroupInc()
        {
            _students = StudentFilters.FilterByGroupInc(_students);
            string minGroup = _students[1].Group;
            foreach (Student student in _students)
            {
                if (Compare(student.Group, minGroup, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    minGroup = student.Group;
                }
            }
            // check that 1-st student in list now have min Group (A < B < C < D etc)
            Assert.AreEqual(minGroup, _students[0].Group);
        }

        [TestMethod]
        public void FilterByGroupDes()
        {
            _students = StudentFilters.FilterByGroupDes(_students);
            string maxGroup = _students[1].Group;
            foreach (Student student in _students)
            {
                if (Compare(student.Group, maxGroup, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    maxGroup = student.Group;
                }
            }
            // check that 1-st student in list now have min Group (A < B < C < D etc)
            Assert.AreEqual(maxGroup, _students[0].Group);
        }

        [TestMethod]
        public void FilterByYearInc()
        {
            _students = StudentFilters.FilterByYearInc(_students);
            int minYear = _students[1].Year;
            foreach (Student student in _students)
            {
                if (student.Year < minYear) minYear = student.Year;
            }
            // check that 1-st student in list now have min Year of birth 
            Assert.AreEqual(minYear, _students[0].Year);
        }

        [TestMethod]
        public void FilterByYearDes()
        {
            _students = StudentFilters.FilterByYearDes(_students);
            int maxYear = _students[1].Year;
            foreach (Student student in _students)
            {
                if (student.Year > maxYear) maxYear = student.Year;
            }
            // check that 1-st student in list now have max Year of birth 
            Assert.AreEqual(maxYear, _students[0].Year);
        }

        [TestMethod]
        public void FilterByPhysicsScoreInc()
        {
            _students = StudentFilters.FilterByPhysicScoreInc(_students);
            int minPhysicsScore = _students[1].PhysicsScore;
            foreach (Student student in _students)
            {
                if (student.PhysicsScore < minPhysicsScore) minPhysicsScore = student.PhysicsScore;
            }
            // check that 1-st student in list now have min Physics Score
            Assert.AreEqual(minPhysicsScore, _students[0].PhysicsScore);
        }

        [TestMethod]
        public void FilterByPhysicsScoreDes()
        {
            _students = StudentFilters.FilterByPhysicScoreDes(_students);
            int maxPhysicsScore = _students[1].PhysicsScore;
            foreach (Student student in _students)
            {
                if (student.PhysicsScore > maxPhysicsScore) maxPhysicsScore = student.PhysicsScore;
            }
            // check that 1-st student in list now have max Physics Score
            Assert.AreEqual(maxPhysicsScore, _students[0].PhysicsScore);
        }

        [TestMethod]
        public void FilterByMathScoreInc()
        {
            _students = StudentFilters.FilterByMathScoreInc(_students);
            int minMathScore = _students[1].Math;
            foreach (Student student in _students)
            {
                if (student.Math < minMathScore) minMathScore = student.Math;
            }
            // check that 1-st student in list now have min Math Score
            Assert.AreEqual(minMathScore, _students[0].Math);
        }

        [TestMethod]
        public void FilterByMathScoreDes()
        {
            _students = StudentFilters.FilterByMathScoreDes(_students);
            int maxMathScore = _students[1].Math;
            foreach (Student student in _students)
            {
                if (student.Math > maxMathScore) maxMathScore = student.Math;
            }
            // check that 1-st student in list now have max Math Score
            Assert.AreEqual(maxMathScore, _students[0].Math);
        }

        [TestMethod]
        public void FilterByInformaticsScoreInc()
        {
            _students = StudentFilters.FilterByInformaticsScoreInc(_students);
            int minInformaticsScore = _students[1].Informatics;
            foreach (Student student in _students)
            {
                if (student.Informatics < minInformaticsScore) minInformaticsScore = student.Informatics;
            }
            // check that 1-st student in list now have min Informatics Score
            Assert.AreEqual(minInformaticsScore, _students[0].Informatics);
        }

        [TestMethod]
        public void FilterByInformaticsScoreDes()
        {
            _students = StudentFilters.FilterByInformaticsScoreDes(_students);
            int maxInformaticsScore = _students[1].Informatics;
            foreach (Student student in _students)
            {
                if (student.Informatics > maxInformaticsScore) maxInformaticsScore = student.Informatics;
            }
            // check that 1-st student in list now have max Informatics Score
            Assert.AreEqual(maxInformaticsScore, _students[0].Informatics);
        }
    }
}