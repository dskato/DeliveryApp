using Domain.Base;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }

        public virtual UserEntity User { get; set; } // Product belongs to one user
        public int UserId { get; set; }

        public virtual List<OrderEntity> Orders { get; set; } // A product can be in many orders
    }
}
