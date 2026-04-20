using System.ComponentModel.DataAnnotations.Schema;

namespace TugasTM1.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [Column("total_price")]
        public decimal TotalPrice { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}