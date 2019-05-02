using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    public static class StudentSearch
    {
        public static void Search()
        {
            /*
             * Search by field menu
             */

            List<Student> list = StudentFromXml.ReadStudentsFromXml();
            List<Student> filteredList = new List<Student>();

            Console.WriteLine("Select field for Search");
            Console.WriteLine("1. Search by ID");
            Console.WriteLine("2. Search by Last Name");
            Console.WriteLine("3. Search by Group");
            Console.WriteLine("4. Search by Year of Birth");
            Console.WriteLine("5. Search by Physics Score");
            Console.WriteLine("6. Search by Math Score");
            Console.WriteLine("7. Search by Informatics");
            Console.Write("Choice : ");

            if (int.TryParse(Console.ReadLine(), out int choiceNumber))
            {
                if (choiceNumber < 1 || choiceNumber > 7)
                {
                    Console.WriteLine("\nWrong Search Input");
                    Console.WriteLine("Press Any Key");
                    Console.ReadKey();
                }
            }

            Console.Write("\nInput Search data : ");
            string data = Console.ReadLine();
            Console.WriteLine();

            try
            {
                switch (choiceNumber)
                {
                    case 1:
                        filteredList = SearchById(list, data);
                        break;
                    case 2:
                        filteredList = SearchByLastName(list, data);
                        break;
                    case 3:
                        filteredList = SearchByGroup(list, data);
                        break;
                    case 4:
                        filteredList = SearchByYear(list, data);
                        break;
                    case 5:
                        filteredList = SearchByPhysicsScore(list, data);
                        break;
                    case 6:
                        filteredList = SearchByMathScore(list, data);
                        break;
                    case 7:
                        filteredList = SearchByInformaticsScore(list, data);
                        break;
                }

                if (filteredList.Count > 0)
                {
                    Console.WriteLine(Student.Header);
                    foreach (Student student in filteredList)
                    {
                        Console.WriteLine(student.Table());
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong data format");
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
        }

        /*
         * Search data by using LINQ and return result for print to Console
         */

        public static List<Student> SearchByInformaticsScore(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.Informatics.Equals(int.Parse(data))).ToList();
        }

        public static List<Student> SearchByMathScore(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.Math.Equals(int.Parse(data))).ToList();
        }

        public static List<Student> SearchByPhysicsScore(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.PhysicsScore.Equals(int.Parse(data))).ToList();
        }

        public static List<Student> SearchByYear(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.Year.Equals(int.Parse(data))).ToList();
        }

        public static List<Student> SearchByGroup(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.Group.ToLower().Contains(data.ToLower())).ToList();
        }

        public static List<Student> SearchByLastName(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.LastName.ToLower().Contains(data.ToLower())).ToList();
        }

        public static List<Student> SearchById(IEnumerable<Student> list, string data)
        {
            return list.Where(x => data != null && x.Id.Equals(int.Parse(data))).ToList();
        }
    }
}