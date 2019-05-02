namespace Main
{
    public static class CorrectDataChecker
    {
        /*
         * Checking that lastName not null and more than 2 characters
         */
        public static bool CheckLastName(string lastName)
        {
            return lastName != null && lastName.Length > 2;
        }

        /*
         * Checking that Group name is minimum 1 character
         */
        public static bool CheckGroup(string @group)
        {
            return !string.IsNullOrEmpty(group);
        }

        /*
         * Checking that Year of birth have 4 digits
         */
        public static bool CheckYear(int year)
        {
            return year.ToString().Length == 4;
        }

        /*
         * Checking that Physics Score between 1 and 5
         */
        public static bool CheckPhysicsScore(int physicScore)
        {
            return physicScore > 0 && physicScore < 6;
        }


        /*
         * Checking that Math Score between 1 and 5
         */
        public static bool CheckMathScore(int mathScore)
        {
            return mathScore > 0 && mathScore < 6;
        }


        /*
         * Checking that Informatics Score between 1 and 5
         */
        public static bool CheckInformaticsScore(int informaticsScore)
        {
            return informaticsScore > 0 && informaticsScore < 6;
        }
    }
}