using System;
using System.Collections.Generic;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentModifyTest
    {
        [TestMethod]
        public void CheckThatStudentDataChanged()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            Student student = new Student(10000, "oldLastName", "oldGroup", 1999, 3, 3, 3);
            list.Add(student);

            list = StudentModify.Parse(list, 10000, "newLastName", "newGroup", 2000, 5 ,5,5);

            bool oldStudentExist = false;
            foreach (var studentCheck in list)
            {
                if (studentCheck.LastName.Equals("oldLastName")) oldStudentExist = true;
            }

            //check that Student with old data now replaces to new Student
            Assert.AreEqual(oldStudentExist, false);

        }
    }
}
