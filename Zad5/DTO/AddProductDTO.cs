using System.ComponentModel.DataAnnotations;

namespace Zad5.DTO
{
    public class AddProductDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int WarehouseId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public AddProductDTO(int productId, int warehouseId, int amount, DateTime createdAt)
        {
            ProductId = productId;
            WarehouseId = warehouseId;
            Amount = amount;
            CreatedAt = createdAt;
        }

       
    }
}
