using System;
using System.Collections.Generic;
using static Main.CorrectDataChecker;

namespace Main
{
    public static class StudentModify
    {
        internal static void Modify()
        {
            /*
             * Replace Student by ID to new Student with new data, that being tested for correct data
             */

            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            StudentList.ListData();
            Console.WriteLine("Select ID from Modify");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                try
                {
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
                        Console.WriteLine("Name should be not Empty");
                        Console.WriteLine("Enter student's group again");
                        group = Console.ReadLine();
                    }

                    int year = 0;
                    Console.WriteLine("Enter student's Year of Birth");
                    if (int.TryParse(Console.ReadLine(), out int d)) year = d;
                    while (!CheckYear(year))
                    {
                        Console.WriteLine("Should by 4 digits");
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

                    List<Student> list2 = Parse(list, id, lastName, group, year, physicScore, mathScore, informaticsScore);

                    StudentToXml.StudentsToXml(list2);

                    /*
                     * Writes to log, that users changed some Student data
                     */

                    LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                        + " Student with ID " + id + " info changed." + " Current Date: "
                                        + DateTime.Now.ToString("dd.MM.yyyy"));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong new data format" + e);
                }       
            }
            else
            {
                Console.WriteLine("Wrong ID format\n");
            }         
        }

        public static List<Student> Parse(List<Student> list, int id, string lastName, string group, 
            int year, int physicScore, int mathScore, int informaticsScore)
        {
            List<Student> list2 = new List<Student>();

            foreach (Student student in list)
            {
                list2.Add(student);
            }

            foreach (Student student in list)
            {
                if (student.Id == id)
                {
                    list2.Remove(student);
                    list2.Add(new Student(id, lastName, group, year, physicScore, mathScore, informaticsScore));
                }
               
            }

            Console.WriteLine();
            return list2;
        }
    }
}