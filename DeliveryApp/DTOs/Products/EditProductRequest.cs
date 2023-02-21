namespace API.DTOs.Products
{
    public class EditProductRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Description { get; set; }
    }
}
