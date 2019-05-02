using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Main
{
    public static class StudentToCsv
    {
        public static void Export()
        {
            /*
             * Write each Student from DataBase line by line to .csv file 
             */

            Console.WriteLine("Input full path to directory for save .scv");
            string path = Console.ReadLine();


            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            WriteToCsv(list, path);
            Console.ReadKey();
        }

        public static void WriteToCsv(IEnumerable<Student> list, string path)
        {
            StringBuilder sb = new StringBuilder();
            const string delimiter = ",";
            try
            {
                foreach (Student student in list)
                {
                    sb.Append(student.Id).Append(delimiter)
                        .Append(student.LastName).Append(delimiter)
                        .Append(student.Group).Append(delimiter)
                        .Append(student.Year).Append(delimiter)
                        .Append(student.PhysicsScore).Append(delimiter)
                        .Append(student.Math).Append(delimiter)
                        .Append(student.Informatics).Append(Environment.NewLine);

                    File.WriteAllText(path + "\\export.csv", sb.ToString());
                }

                Console.WriteLine("Saved at " + path + "\\export.csv");
                Console.WriteLine("Press any key");
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong path format");
                Console.WriteLine("Press any key");
            }
        }
    }
}