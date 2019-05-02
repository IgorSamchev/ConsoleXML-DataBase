using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    public static class StudentFilters
    {
        internal static void Filters()
        {
            List<Student> list = StudentFromXml.ReadStudentsFromXml();

            /*
             * Filters menu. Program sorts list as selected by user and returns to .xml
             */

            Console.WriteLine("Filters menu");
            Console.WriteLine("1. Filter by ID (inc)");
            Console.WriteLine("2. Filter by ID (des)");
            Console.WriteLine("3. Filter by Last Name (inc)");
            Console.WriteLine("4. Filter by Last Name (des)");
            Console.WriteLine("5. Filter by Group (inc)");
            Console.WriteLine("6. Filter by Group (des)");
            Console.WriteLine("7. Filter by Year of birth (inc)");
            Console.WriteLine("8. Filter by Year of birth (des)");
            Console.WriteLine("9. Filter by Physics Score (inc)");
            Console.WriteLine("10.Filter by Physics Score (des)");
            Console.WriteLine("11.Filter by Math Score (inc)");
            Console.WriteLine("12.Filter by Math Score (des)");
            Console.WriteLine("13.Filter by Informatics Score (inc)");
            Console.WriteLine("14.Filter by Informatics Score (des)");

            Console.WriteLine("\nSelect Filter");
            Console.Write("Choice : ");
            string filter = Console.ReadLine();

            switch (filter)
            {
                case "1":
                    list = FilterByIdInc(list);
                    break;
                case "2":
                    list = FilterByIdDes(list);
                    break;
                case "3":
                    list = FilterByNameInc(list);
                    break;
                case "4":
                    list = FilterByNameDes(list);
                    break;
                case "5":
                    list = FilterByGroupInc(list);
                    break;
                case "6":
                    list = FilterByGroupDes(list);
                    break;
                case "7":
                    list = FilterByYearInc(list);
                    break;
                case "8":
                    list = FilterByYearDes(list);
                    break;
                case "9":
                    list = FilterByPhysicScoreInc(list);
                    break;
                case "10":
                    list = FilterByPhysicScoreDes(list);
                    break;
                case "11":
                    list = FilterByMathScoreInc(list);
                    break;
                case "12":
                    list = FilterByMathScoreDes(list);
                    break;
                case "13":
                    list = FilterByInformaticsScoreInc(list);
                    break;
                case "14":
                    list = FilterByInformaticsScoreDes(list);
                    break;
                default:
                    Console.WriteLine("Wrong filter selected");
                    break;
            }

            Console.WriteLine();

            /*
             * Writes to log, that user used some filter
             */

            LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                + " Used Student filter. Current Date: "
                                + DateTime.Now.ToString("MM.dd.yyyy"));

            StudentToXml.StudentsToXml(list);
        }

        /*
         * LINQ sorts
         */

        public static List<Student> FilterByInformaticsScoreDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Informatics).Reverse().ToList();
        }

        public static List<Student> FilterByInformaticsScoreInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Informatics).ToList();
        }

        public static List<Student> FilterByMathScoreDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Math).Reverse().ToList();
        }

        public static List<Student> FilterByMathScoreInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Math).ToList();
        }

        public static List<Student> FilterByPhysicScoreDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.PhysicsScore).Reverse().ToList();
        }

        public static List<Student> FilterByPhysicScoreInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.PhysicsScore).ToList();
        }

        public static List<Student> FilterByYearDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Year).Reverse().ToList();
        }

        public static List<Student> FilterByYearInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Year).ToList();
        }

        public static List<Student> FilterByGroupDes(List<Student> list)
        {
            return list.OrderBy(x => x.Group).Reverse().ToList();
        }

        public static List<Student> FilterByGroupInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Group).ToList();
        }

        public static List<Student> FilterByNameDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.LastName).Reverse().ToList();
        }

        public static List<Student> FilterByNameInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.LastName).ToList();
        }

        public static List<Student> FilterByIdDes(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Id).Reverse().ToList();
        }

        public static List<Student> FilterByIdInc(IEnumerable<Student> list)
        {
            return list.OrderBy(x => x.Id).ToList();
        }
    }
}