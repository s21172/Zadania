using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorClientSideSamples.Shared.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }

        public string Address { get; set; }
        public DateTime Birthdate { get; set; }

        [Range(1, 40000)]
        public int IndexNumber { get; set; }
    }
}
