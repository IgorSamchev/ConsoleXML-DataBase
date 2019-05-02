using System;
using System.Collections.Generic;
using System.Xml;


namespace Main
{
    public static class StudentFromXml
    {
        public static List<Student> ReadStudentsFromXml()
        {
            List<Student> students = new List<Student>();

            try
            {
                /*
                 * Path - default .xml file location
                 */

                string path = "objstore\\students.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);


                if (doc.DocumentElement != null)
                    foreach (XmlElement el in doc.DocumentElement.ChildNodes)
                    {
                        Student s = FromXml(el);
                        if (s != null) students.Add(s);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return students;
        }

        private static Student FromXml(XmlElement el)
        {
            /*
             * Read XML element and create new Student
             */

            string[] names = {"ID", "LastName", "Group", "Year", "PhysicsScore", "Math", "Informatics"};
            string[] values = new string[names.Length];

            if (el == null || el.Name != "Student") return null;

            for (int i = 0; i < names.Length; i++)
            {
                XmlNodeList elements = el.GetElementsByTagName(names[i]);
                if (elements.Count != 0) values[i] = elements[0].InnerText;
                else return null;
            }

            return new Student(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]),
                int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6]));
        }
    }
}