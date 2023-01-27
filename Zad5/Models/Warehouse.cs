using System.ComponentModel.DataAnnotations;

namespace Zad5.Models
{
    public class Warehouse
    {
        [Key]
        public int IdWarehouse { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public Warehouse(int idWarehouse, string name, string address)
        {
            IdWarehouse = idWarehouse;
            Name = name;
            Address = address;
        }
    }
}
