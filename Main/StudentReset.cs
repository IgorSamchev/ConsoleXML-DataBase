using System;
using System.Collections.Generic;

namespace Main
{
    public static class StudentReset
    {
        internal static void Reset()
        {
            /*
             * Delete all Students from DataBase and put 4 default new Students
             */

            Console.WriteLine("RESET DATABASE? To continue press 'y'");
            if (Console.ReadKey().KeyChar != 'y') return;

            // ReSharper disable once UnusedVariable
            List<Student> list = DeleteAllAndPutFourDefaultStudents();

            Console.WriteLine("\n\n");

            /*
             * Writes to log, that user used DataBase reset
             */

            LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                + " Database Reset. Current Date: "
                                + DateTime.Now.ToString("dd.MM.yyyy"));
        }

        public static List<Student> DeleteAllAndPutFourDefaultStudents()
        {
            List<Student> list = new List<Student>
            {
                new Student(0, "Ivanov", "A", 1987, 5, 4, 3),
                new Student(1, "Petrov", "A", 1989, 3, 4, 5),
                new Student(2, "Sidorov", "B", 1985, 5, 4, 3),
                new Student(3, "Smith", "B", 1989, 2, 4, 3)
            };
            StudentToXml.StudentsToXml(list);
            return list;
        }
    }
}