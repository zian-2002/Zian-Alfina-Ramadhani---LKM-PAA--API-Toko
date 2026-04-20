using System.ComponentModel.DataAnnotations.Schema;

namespace TugasTM1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}