using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;
using Zad3.Models;

namespace Zad3.Utils
{
    public class UtilsIO
    {
        public static string FilePath = @"Data\dane.csv";


        public static List<Student> readFile()
        {

            var students = new List<Student>();
            if (File.Exists(FilePath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    HasHeaderRecord = false
                };

                var classMap = new StudentMap();

                using (var reader = new StreamReader(FilePath))

                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap(classMap);
                    students.AddRange(csv.GetRecords<Student>());
                }
            }
            return students;
        }


        public static void saveStudent(Student student)
        {
            FileStream fileStreamExisting = null;
            if (File.Exists(FilePath))
            {
                fileStreamExisting = new FileStream(FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            }
            else
            {
                fileStreamExisting = new FileStream(FilePath, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite);
            }
            using (FileStream fstream = fileStreamExisting)
            {

                using (StreamWriter streamWriter = new StreamWriter(fstream))
                {
                    var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };
                    using (var csv = new CsvWriter(streamWriter, configuration))
                    {
                        csv.NextRecordAsync();
                        csv.WriteRecord(student);

                        csv.Dispose();
                    }
                    streamWriter.Close();
                }
                fstream.Close();
            }
        }


        public static void overrideFile(List<Student> students)
        {
            FileStream fileStreamExisting = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

            using (FileStream fstream = fileStreamExisting)
            {

                using (StreamWriter streamWriter = new StreamWriter(fstream))
                {
                    var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };
                    using (var csv = new CsvWriter(streamWriter, configuration))
                    {
                        csv.WriteRecords(students);

                        csv.Dispose();
                    }
                    streamWriter.Close();
                }
                fstream.Close();
            }
        }

        public static bool checkIndeksFormat(string studentId)
        {
            Regex reg = new Regex("s[0-9]{5}");
            Match match = reg.Match(studentId);
            if (match.Success)
            {
                return true;
            }
            return false;
                
        }
    }
}
