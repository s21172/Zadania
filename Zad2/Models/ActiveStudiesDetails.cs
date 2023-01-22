namespace Zad2.Models
{
    class ActiveStudiesDetails
    {
        public string StudiesName { get; set; }
        public int StudentsCount { get; set; }

        public static List<ActiveStudiesDetails> AllStudiesDetails = new();
        

        public ActiveStudiesDetails(string studiesName, int studentsCount)
        {
            StudiesName = studiesName;
            StudentsCount = studentsCount;
        }

        public override string? ToString()
        {
            return StudiesName + ", studentsNumber: " + StudentsCount;
        }
    }
}
