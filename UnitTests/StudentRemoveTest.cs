using System.Collections.Generic;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StudentRemoveTest
    {
        [TestMethod]
        public void RemoveStudentById()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            list.Add(new Student(10005, "deleteMe", "someGroup", 2000, 5, 5, 5));
            List<Student> result = StudentRemove.RemoveStudentFromList(list, 10005);

            bool isStudentExist = false;

            foreach (Student student in result)
            {
                if (student.LastName.Equals("deleteMe")) isStudentExist = true;
            }

            //check that student no more exist
            Assert.AreEqual(false, isStudentExist);
        }
    }
}