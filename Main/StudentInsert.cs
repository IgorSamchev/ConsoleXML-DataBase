using System;
using System.Collections.Generic;
using static Main.CorrectDataChecker;

namespace Main
{
    public static class StudentInsert
    {
        public static void Insert()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            /*
             * Adding new Student to DataBase. Checking correct data input.
             */

            Console.WriteLine("Enter student's last name");
            string lastName = Console.ReadLine();
            while (!CheckLastName(lastName))
            {
                Console.WriteLine("Name should be more than 3 characters");
                Console.WriteLine("Enter student's last name again");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter student's group");
            string group = Console.ReadLine();
            while (!CheckGroup(group))
            {
                Console.WriteLine("Group name should be not Empty");
                Console.WriteLine("Enter student's group again");
                group = Console.ReadLine();
            }

            int year = 0;
            Console.WriteLine("Enter student's Year of Birth");
            if (int.TryParse(Console.ReadLine(), out int d)) year = d;
            while (!CheckYear(year))
            {
                Console.WriteLine("Should be 4 digits");
                Console.WriteLine("Enter student's Year of Birth again");
                if (int.TryParse(Console.ReadLine(), out int d2)) year = d2;
            }

            int physicScore = 0;
            Console.WriteLine("Enter student's Physic Score");
            if (int.TryParse(Console.ReadLine(), out int a)) physicScore = a;
            while (!CheckPhysicsScore(physicScore))
            {
                Console.WriteLine("Should be from 1 till 5");
                Console.WriteLine("Enter student's Physic Score again");
                if (int.TryParse(Console.ReadLine(), out int a2)) physicScore = a2;
            }

            int mathScore = 0;
            Console.WriteLine("Enter student's Math Score");
            if (int.TryParse(Console.ReadLine(), out int b)) mathScore = b;
            while (!CheckMathScore(mathScore))
            {
                Console.WriteLine("Should be from 1 till 5");
                Console.WriteLine("Enter student's Math Score Score again");
                if (int.TryParse(Console.ReadLine(), out int b2)) mathScore = b2;
            }

            int informaticsScore = 0;
            Console.WriteLine("Enter student's Informatics Score");
            if (int.TryParse(Console.ReadLine(), out int c)) informaticsScore = c;
            while (!CheckInformaticsScore(informaticsScore))
            {
                Console.WriteLine("Should be from 1 till 5");
                Console.WriteLine("Enter student's Informatics Score again");
                if (int.TryParse(Console.ReadLine(), out int c2)) informaticsScore = c2;
            }

            int maxId = GenerateNextId() + 1;

            Student student = new Student(maxId, lastName, group, year, physicScore, mathScore, informaticsScore);
            list.Add(student);
            StudentToXml.StudentsToXml(list);
            Console.WriteLine("\nNew Student added\n");

            /*
             * Writes to log, that user added new Student
             */

            LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                + " Added new Student: " + student.LastName + ". Current Date: "
                                + DateTime.Now.ToString("dd.MM.yyyy"));
        }

        /*
         * checking maximum ID in DataBase and generates new ID
         */

        public static int GenerateNextId()
        {
            int maxId = 0;
            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            foreach (Student student in list)
            {
                if (student.Id > maxId) maxId = student.Id;
            }

            return maxId;
        }
    }
}