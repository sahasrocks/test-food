using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }
        public virtual User? User { get; set; }
        public virtual Menu? Item { get; set; }
    }
}
