using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Main
{
    public static class StudentImportCsv
    {
        internal static void Import()
        {
            Console.WriteLine("Input full path to file for load .csv");
            string path = Console.ReadLine();

            List<Student> list = ReadFromCsv(path);
            StudentToXml.StudentsToXml(list);
        }

        public static List<Student> ReadFromCsv(string path)
        {
            List<Student> list = new List<Student>();
            try
            {
                if (path != null)
                {
                    /*
                     * Read line by line .CSV file and try to parse each line to new Student
                     */
                    List<string> lines = File.ReadLines(path).ToList();
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        list.Add(new Student(int.Parse(values[0]), values[1], values[2], int.Parse(values[3]),
                            int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6])));
                    }
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect .csv data format");
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }

            return list;
        }
        
        
    }
}