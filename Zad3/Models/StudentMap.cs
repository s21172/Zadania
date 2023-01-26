using CsvHelper.Configuration;

namespace Zad3.Models
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {

            Map(s => s.Imie).Index(0);

            Map(s => s.Nazwisko).Index(1);

            Map(s => s.IdStudenta).Index(2);

            Map(s => s.DataUrodzenia).Index(3);

            Map(s => s.Studia).Index(4);

            Map(s => s.Tryb).Index(5);

            Map(s => s.Email).Index(6);

            Map(s => s.ImieOjca).Index(7);

            Map(s => s.ImieMatki).Index(8);
        }       
    }
}
