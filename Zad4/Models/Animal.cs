using System.ComponentModel.DataAnnotations;

namespace Zad4.Models
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }

        [Required(ErrorMessage = "This field is required" )]
        [MaxLength(200, ErrorMessage = "Max length is 200")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "Max length is 200")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(200, ErrorMessage = "Max length is 200")]
        public string Category { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(200, ErrorMessage = "Max length is 200")]
        public string Area { get; set; }
    }
}
