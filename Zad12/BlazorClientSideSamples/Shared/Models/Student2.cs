using System.ComponentModel.DataAnnotations;

namespace BlazorClientSideSamples.Shared.Models
{
    public class Student2
    {
        public int IdStudent { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
