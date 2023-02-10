using Domain.Base;

namespace Domain.Entities
{
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }
        public string? PickUpAddress { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Description { get; set; }
        public virtual ProductEntity? Product { get; set; }
        public long? ProductId { get; set; }
        public virtual UserEntity? RequestingUser { get; set; }
        public long? RequestingUserId { get; set; }
        public virtual UserEntity? CouriergUser { get; set; }
        public long? CourierUserId { get; set; }

    }
}
