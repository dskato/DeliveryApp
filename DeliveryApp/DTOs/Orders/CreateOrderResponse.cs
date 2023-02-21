namespace API.DTOs.Orders
{
    public class CreateOrderResponse
    {
        public string? PickUpAddress { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Description { get; set; }
        public long? ProductId { get; set; }
        public long? RequestingUserId { get; set; }
        public long? CourierUserId { get; set; }
    }
}
