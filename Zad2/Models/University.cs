using Newtonsoft.Json;

namespace Zad2.Models
{
    internal class University
    {
        public string CreatedAt { get; set; }

        public string Author { get; set; }

        public List<Student> Studenci { get; set; } = new();

        public List<ActiveStudiesDetails> ActiveStudiesList { get; set; }

        public University(string createdAt, string author, List<Student> studenci, List<ActiveStudiesDetails> activeStudies)
        {
            CreatedAt = createdAt;
            Author = author;
            Studenci = studenci;
            ActiveStudiesList = activeStudies;
        }

        public static int CalculateNumberOfStudents(string studiesName)
        {
            var counter = 0;
            foreach (var student in Student.students)
            {
                if (studiesName.Equals(student.Studies.Name))
                {
                    counter += 1;
                    //Console.WriteLine(student.Studies.Name + " " +counter);
                }
            }
            return counter;
        }

        public static void GetActiveStudies()
        {
            foreach (string name in Studies.uniqueNameStudies)
            {
                var numberOfStudents = CalculateNumberOfStudents(name);
                if(numberOfStudents > 0)
                {
                    ActiveStudiesDetails.AllStudiesDetails.Add(new ActiveStudiesDetails(name, numberOfStudents));
                }
            }                
        }

        public static void CreateJSON()
        {
            University uni = new("2023-01-20", "Justyna Berek", Student.students.ToList(), ActiveStudiesDetails.AllStudiesDetails);
            string json = JsonConvert.SerializeObject(uni, Formatting.Indented);
            File.WriteAllText(@"..\..\..\ResultData\University_result.json", json);
            Console.WriteLine("Plik wynikowy zostal pomyslnie zapisany w folderze \"ResultData\" ");
        }
    }
}
