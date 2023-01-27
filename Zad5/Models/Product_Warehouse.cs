using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad5.Models
{
    public class Product_Warehouse
    {
        [Key]
        public int IdProductWarehouse { get; set; }

        [ForeignKey(nameof(IdProductNavigation))]
        public int IdProduct { get; set; }
        public virtual Product IdProductNavigation { get; set; }

        [ForeignKey(nameof(IdWarehouseNavigation))]
        public int IdWarehouse { get; set; }
        public virtual Warehouse IdWarehouseNavigation { get; set; }

        [ForeignKey(nameof(IdOrderNavigation))]
        public int IdOrder { get; set; }
        public virtual Order IdOrderNavigation { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        [Required(ErrorMessage = "Amount cannot be empty.")]
        public int Amount { get; set; }

        [Required]
        [Column(TypeName = "decimal(25,2)")]
        public double Price { get; set; }

        [Required]
        [DefaultValue("getutcdate()")]
        public DateTime CreatedAt { get; set; }
    }
}
