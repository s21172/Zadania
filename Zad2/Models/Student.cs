namespace Zad2.Models
{
    internal class Student : IEquatable<Student>
    {
        public string IndexNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public Studies Studies { get; set; }

        public static HashSet<Student> students = new();

        public Student(string indexNumber, string fName, string lName, string birthDate, string email, string mothersName, string fathersName, Studies studies)
        {
            IndexNumber = indexNumber;
            FName = fName;
            LName = lName;
            BirthDate = birthDate;
            Email = email;
            MothersName = mothersName;
            FathersName = fathersName;
            Studies = studies;
        }

        public override string? ToString()
        {
            return "Numer indeksu: " + IndexNumber + ", Student: " + FName + " " + LName + 
                ",\nEmail: " + Email + ", Data urodzenia: " + BirthDate + 
                ",\nImiona rodzicow: " + MothersName + " i " + FathersName + ",\nKierunek i tryb studiow: " + Studies;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Student);
        }

        public bool Equals(Student other)
        {
            if (other == null)
                return false;

            return 
                 (
                    object.ReferenceEquals(this.FName, other.FName) ||
                    this.FName.Equals(other.FName)
                ) &&
                (
                    object.ReferenceEquals(this.LName, other.LName) ||
                    this.LName.Equals(other.LName)
                ) &&
                (
                    object.ReferenceEquals(this.IndexNumber, other.IndexNumber) ||
                    this.IndexNumber.Equals(other.IndexNumber)
                );
        }

        public override int GetHashCode()
        {
            return FName.GetHashCode() ^
                LName.GetHashCode() ^
                IndexNumber.GetHashCode();
        }
    }
}
