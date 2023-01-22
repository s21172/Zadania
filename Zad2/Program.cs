using Microsoft.VisualBasic.FileIO;
using Zad2.Models;
using Zad2.Utils;
using Zad2.Logging;

namespace Zad2
{
    public class Program
    {
        static void Main(string[] args) {
            string logPath = @"..\..\..\Logging\log.txt";
            if (File.Exists(logPath))
            {
                File.Delete(logPath);
            }

            if (args.Length == 0)
            {
                Logger.AddLog("Exception Error: Nie podano ścieżki do pliku !!");
                throw new FileNotFoundException("Nie podano ścieżki do pliku !!");
            }
            else if (UtilsIO.IsValidPath(@args[0]))
            {
                Logger.AddLog("Exception Error: Nieprawidłowa ścieżka do pliku !!");
                throw new ArgumentException("Nieprawidłowa ścieżka do pliku !!");
            }
            else if (!File.Exists(@args[0]))
            {
                var filename = Path.GetFileName(@args[0]);
                Logger.AddLog("Exception Error: Plik " + filename + " nie isnieje !!");
                throw new  FileNotFoundException("Plik " + filename + " nie isnieje !!");
            } else
            {
                using (TextFieldParser parser = new TextFieldParser(@args[0]))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        if (fields[2] != "" && fields[3] != "")
                        {
                            Studies.uniqueStudies.Add(new Studies(fields[2], fields[3])); 
                        }
                    }
                }
                using (TextFieldParser parser = new TextFieldParser(@args[0]))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    var counter = 0;

                    while (!parser.EndOfData)
                    {
                        counter++;

                        string[] fields = parser.ReadFields();
                        bool valid = true;
                        foreach(var f in fields) {
                            if(f== "" || f== null)
                            {
                                valid = false;
                            }
                        }

                        if (!valid)
                        {
                            Logger.AddLog("Error: Nie można dodać studenta z powodu braku wystarczających danych!! \nDane:  " + String.Join(",", fields) + "\nLine number: " + counter + "\n");
                        }
                        else
                        { 
                            Student s = new(fields[4], fields[0], fields[1], fields[5], fields[6], fields[7], fields[8], new Studies(fields[2], fields[3]));

                            if (Student.students.Contains(s))
                            {
                                Logger.AddLog("Error: Student o takim imieniu, nazwisku i numerze indeksu juz istnieje!!\nDane: " + String.Join(",", fields) + "\nLine number: " + counter + "\n");
                            }
                            else 
                            { 
                                Student.students.Add(s);
                            }
                        }
                    }
                    Studies.GetUniqueStudiesNames();
                    University.GetActiveStudies();
                }
                if (File.Exists(logPath))
                {
                    Console.WriteLine("Niektore rekordy nie zostaly zapisane z powodu blednych danych - szczegoly bledow w \"log.txt\" file ");
                }
                University.CreateJSON();
                
            }
        } 
    }
}

