namespace API.DTOs.Orders
{
    public class GetOrderResponse
    {
        public int? Id { get; set; }
        public string? PickUpAddress { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Description { get; set; }
        public int? ProductId { get; set; }
        public int? RequestingUserId { get; set; }
        public int? CourierUserId { get; set; }
    }
}
