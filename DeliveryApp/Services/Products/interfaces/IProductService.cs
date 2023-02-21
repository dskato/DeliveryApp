using API.DTOs.Products;

namespace API
{
    public partial interface IApplicationService
    {
        CreateProductResponse CreateProduct(CreateProductRequest request);
        bool DeleteProductById(int productId);
        GetProductResponse GetProductById(int productId);
        GetProductResponse EditProductInfo(EditProductRequest request);
    }
}
