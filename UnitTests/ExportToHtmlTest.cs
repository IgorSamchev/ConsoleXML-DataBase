using System.Collections.Generic;
using System.IO;
using System.Text;
using Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExportToHtmlTest
    {
        [TestMethod]
        public void WriteToHtmlTest()
        {
            List<Student> students = StudentFromXml.ReadStudentsFromXml();
            StudentToHtml.WriteToHtml(students);

            string[] lines = File.ReadAllLines("objstore\\students.html");
            const int expectedLength = 68;
            Assert.AreEqual(expectedLength, lines.Length);

            StringBuilder sb = new StringBuilder();
            foreach (var line in lines)
            {
                sb.Append(line);
            }
            //basic tags and border
            const string expectedResult = "<TABLE border=\"1\">" +
                                          "<TR>" +
                                          "<TD>ID</TD>" +
                                          "<TD>Last Name</TD>" +
                                          "<TD>Group</TD>" +
                                          "<TD>Year</TD>" +
                                          "<TD>Physics</TD>" +
                                          "<TD>Math</TD>" +
                                          "<TD>Informatics</TD>" +
                                          "</TR>" +
                                          "<TR>" +
                                          "<TD>0</TD>" +
                                          "<TD>Ivanov</TD>" +
                                          "<TD>A</TD>" +
                                          "<TD>1987</TD>" +
                                          "<TD>5</TD>" +
                                          "<TD>4</TD>" +
                                          "<TD>3</TD>" +
                                          "</TR>" +
                                          "<TR>" +
                                          "<TD>1</TD>" +
                                          "<TD>Petrov</TD>" +
                                          "<TD>A</TD>" +
                                          "<TD>1989</TD>" +
                                          "<TD>3</TD>" +
                                          "<TD>4</TD>" +
                                          "<TD>5</TD>" +
                                          "</TR>" +
                                          "<TR>" +
                                          "<TD>2</TD>" +
                                          "<TD>Sidorov</TD>" +
                                          "<TD>B</TD>" +
                                          "<TD>1985</TD>" +
                                          "<TD>5</TD>" +
                                          "<TD>4</TD>" +
                                          "<TD>3</TD>" +
                                          "</TR>" +
                                          "<TR>" +
                                          "<TD>3</TD>" +
                                          "<TD>Smith</TD>" +
                                          "<TD>B</TD>" +
                                          "<TD>1989</TD>" +
                                          "<TD>2</TD>" +
                                          "<TD>4</TD>" +
                                          "<TD>3</TD>" +
                                          "</TR>" +
                                          "<TR>" +
                                          "<TD>333</TD>" +
                                          "<TD>LastName</TD>" +
                                          "<TD>KTA-18V</TD>" +
                                          "<TD>1999</TD>" +
                                          "<TD>5</TD>" +
                                          "<TD>5</TD>" +
                                          "<TD>5</TD>" +
                                          "</TR>" +
                                          "</TABLE>";
            Assert.AreEqual(expectedResult, sb.ToString());

        }
    }
}
