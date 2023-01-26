using Zad3.Models;
using Zad3.Utils;

namespace Zad3.Services
{
    public class CSVService : ICSVService

    {
        public void Add(Student student)
        {
            HashSet<Student> studentSet = new HashSet<Student>(UtilsIO.readFile());
            if (studentSet.Contains(student))
            {
                throw new StudentDuplicatedException("Student o podanym numerze indeksu: \"" + student.IdStudenta + "\" już istnieje");
            }
            if (!UtilsIO.checkIndeksFormat(student.IdStudenta))
            {
                throw new InvalidDataException("Wprowadzono nieprawidlowy format numeru indeksu, poprawny format to 5 cyfr poprzedzonych litera s np. s12345");
            }
            studentSet.Add(student);
            UtilsIO.overrideFile(studentSet.ToList());
        }


        public void Edit(string studentId, Student newStudentData)
        {
            if(!newStudentData.IdStudenta.Equals(studentId))
            {
                throw new StudentException("Nie mozna zmienic numeru indeksu studenta");
            }

            List<Student> allStudents = UtilsIO.readFile();
            var oldStudentData = GetByID(studentId);
            allStudents.Remove(oldStudentData);
            allStudents.Add(newStudentData);

            if (oldStudentData != null)
            {
                allStudents.Remove(oldStudentData);
                allStudents.Add(newStudentData);
            }


            UtilsIO.overrideFile(allStudents);
        }

        public List<Student> GetAll()
        {
            List<Student> allStudents = (UtilsIO.readFile());
            if (allStudents == null || allStudents.Count == 0)
            {
                if (!File.Exists(UtilsIO.FilePath))
                {
                    throw new FileNotFoundException("Plik \"" + UtilsIO.FilePath + "\" nie istnieje");
                }
                throw new FileNotFoundException("Brak rekordow do wyswietlenia");    
            }
            return allStudents;
        }

        public Student GetByID(string studentId)
        {

            List<Student> studentsList = GetAll();
            foreach (var s in studentsList)
            {
                if (s.IdStudenta.Equals(studentId))
                {
                    return s;
                }
            }
            throw new StudentException("Student o podanym numerze indeksu: \"" + studentId + "\" nie istnieje");
        }

        public void Remove(string studentId)
        {
            List<Student> studentsList = GetAll();
            var student = GetByID(studentId);
            studentsList.Remove(student);
            UtilsIO.overrideFile(studentsList);
        }
    }
}
