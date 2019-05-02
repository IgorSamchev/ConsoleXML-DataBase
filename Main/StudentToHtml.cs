using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Main
{
    public static class StudentToHtml
    {
        internal static void ExportToHtml()
        {
            /*
             * Creates HTML table from Students with basic tags and border
             */

            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            WriteToHtml(list);

            Console.WriteLine("Export done to objstore/Students.html file\n");
        }

        public static void WriteToHtml(List<Student> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<TABLE border=\"1\">").Append(Environment.NewLine);

            sb
                .Append("<TR>\n").Append(Environment.NewLine)
                .Append("<TD>").Append("ID").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Last Name").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Group").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Year").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Physics").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Math").Append("</TD>").Append(Environment.NewLine)
                .Append("<TD>").Append("Informatics").Append("</TD>").Append(Environment.NewLine)
                .Append("</TR>\n").Append(Environment.NewLine);

            foreach (Student student in list)
            {
                sb
                    .Append("<TR>\n").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.Id).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.LastName).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.Group).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.Year).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.PhysicsScore).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.Math).Append("</TD>").Append(Environment.NewLine)
                    .Append("<TD>").Append(student.Informatics).Append("</TD>").Append(Environment.NewLine)
                    .Append("</TR>\n").Append(Environment.NewLine);
            }

            sb.Append("</TABLE>");

            File.WriteAllText("objstore\\students.html", sb.ToString());
        }
    }
}