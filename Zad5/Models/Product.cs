using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad5.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(25,2)")]
        public double Price { get; set; }

        public Product(int idProduct, string name, string description, double price)
        {
            IdProduct = idProduct;
            Name = name;
            Description = description;
            Price = price;
        }

        public Product()
        {
        }
    }
}
