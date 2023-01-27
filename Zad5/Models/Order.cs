using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad5.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }

        [ForeignKey(nameof(IdProductNavigation))]
        public int IdProduct { get; set; }
        public Product IdProductNavigation { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        [Required(ErrorMessage = "Amount cannot be empty.")]
        public int Amount { get; set; }

        [Required]
        public DateTime CreatedAt
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;

        public DateTime? FulfilledAt { get; set; }

    }
}
