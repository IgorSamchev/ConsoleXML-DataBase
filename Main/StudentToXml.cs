using System.Collections.Generic;
using System.Xml;

namespace Main
{
    public static class StudentToXml
    {
        public static void StudentsToXml(IEnumerable<Student> std)
        {
            XmlWriterSettings settings = new XmlWriterSettings {Indent = true};
            XmlWriter wr = XmlWriter.Create("objstore\\students.xml", settings);

            wr.WriteStartDocument(); // begin document

            wr.WriteStartElement("Students"); // root node
            foreach (Student s in std) ToXml(wr, s); // <Student> nodes
            wr.WriteEndElement(); // end root node

            wr.WriteEndDocument(); // end document
            wr.Close(); // close the writer
        }

        private static void ToXml(XmlWriter wr, Student student)
        {
            wr.WriteStartElement("Student"); // <Student>
            wr.WriteElementString("ID", student.Id.ToString());
            wr.WriteElementString("LastName", student.LastName);
            wr.WriteElementString("Group", student.Group);
            wr.WriteElementString("Year", student.Year.ToString());
            wr.WriteElementString("PhysicsScore", student.PhysicsScore.ToString());
            wr.WriteElementString("Math", student.Math.ToString());
            wr.WriteElementString("Informatics", student.Informatics.ToString());

            wr.WriteEndElement(); // </Student>
        }
    }
}