using System;
using System.Collections.Generic;

namespace Main
{
    internal static class StudentList
    {
        internal static void ListData()
        {

            /*
             * Prints all Students to Console
             */

            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            Console.WriteLine(Student.Header);
            foreach (Student student in list)
            {
                Console.WriteLine(student.Table());
            }

            Console.WriteLine();
        }
    }
}