using System.ComponentModel.DataAnnotations;

namespace Zad3.Models
{
    public class Student : IEquatable<Student>
    {
        
        [Required]
        public string Imie { get; set; }
        
        [Required]
        public string Nazwisko { get; set; }

        [Required]
        public string IdStudenta { get; set; }

        [Required]
        public string DataUrodzenia { get; set; }
        
        [Required]
        public string Studia { get; set; }
        
        [Required]
        public string Tryb { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string ImieOjca { get; set; }
        
        [Required]
        public string ImieMatki { get; set; }


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
                    object.ReferenceEquals(this.IdStudenta, other.IdStudenta) ||
                    this.IdStudenta.Equals(other.IdStudenta)
                );
        }

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return IdStudenta.GetHashCode();
        }
    }
}
