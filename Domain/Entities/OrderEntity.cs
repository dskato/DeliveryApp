using Domain.Base;

namespace Domain.Entities
{
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }
        public string? PickUpAddress { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Description { get; set; }

        public virtual ProductEntity Product { get; set; } // An order has one product
        public int ProductId { get; set; }

        public virtual UserEntity RequestingUser { get; set; } // An order has one requesting user
        public int RequestingUserId { get; set; }

        public virtual UserEntity? CourierUser { get; set; } // An order has one courier user
        public int? CourierUserId { get; set; }

    }
}
