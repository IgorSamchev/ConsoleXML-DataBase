namespace Main
{
    public class Student
    {
        public readonly int Id;
        public readonly string LastName;
        public readonly string Group;
        public readonly int Year;
        public readonly int PhysicsScore;
        public readonly int Math;
        public readonly int Informatics;

        public const string Header = "ID\tLastName\tGroup\t\tYear\tPhysics\tMath\tInformatics\n";

        public Student()
        {
        }

        public Student(int id, string lastName, string group, int year, int physics, int math, int informatics)
        {
            Id = id;
            LastName = lastName;
            Group = group;
            Year = year;
            PhysicsScore = physics;
            Math = math;
            Informatics = informatics;
        }

        public string Table()
        {
            return
                $"{Id}\t{LastName}{(LastName.Length > 8 ? "" : "\t")}\t{Group}\t\t{Year}\t{PhysicsScore}\t{Math}\t{Informatics}";
        }
    }
}