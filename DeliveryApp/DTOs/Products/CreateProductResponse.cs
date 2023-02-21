namespace API.DTOs.Products
{
    public class CreateProductResponse
    {

        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }
        public long? UserId { get; set; }

    }
}
