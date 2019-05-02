using System;
using System.Collections.Generic;

namespace Main
{
    public static class StudentRemove
    {
        internal static void Remove()
        {
            /*
             * Delete Student from DataBase with confirmation
             */

            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            StudentList.ListData();
            Console.WriteLine("Select Student ID to remove Student");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("DELETE Student from DataBase? To continue press 'y'");
                if (Console.ReadKey().KeyChar != 'y')
                {
                    Console.WriteLine("\n");
                    return;
                }

                List<Student> filteredFromList = RemoveStudentFromList(list, id);
                Console.WriteLine("\n");
                StudentToXml.StudentsToXml(filteredFromList);
            }
            else
            {
                Console.WriteLine("Wrong ID format");
                Console.WriteLine();
            }
        }

        public static List<Student> RemoveStudentFromList(List<Student> list, int id)
        {
            List<Student> result = new List<Student>();
            foreach (Student v in list) result.Add(v);

            foreach (Student student in list)
            {
                if (student.Id != id) continue;
                result.Remove(student);

                /*
                 * Writes to log, that user deleted some Student
                 */

                LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                    + " Student with ID " + id + " removed. Current Date: "
                                    + DateTime.Now.ToString("dd.MM.yyyy"));
            }

            return result;
        }
    }
}