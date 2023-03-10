
using API.DTOs.Products;
using Domain.Entities;

namespace API
{
    public partial class ApplicationService : IApplicationService
    {
        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {

            CreateProductResponse response = new CreateProductResponse();

            ProductEntity entity = new ProductEntity();
            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Weight = request.Weight;
            entity.UserId = request.UserId;
            entity.CreateDate = DateTime.Now;

            this._productDomainRepository.CreateProduct(entity);

            response.Name = entity.Name;
            response.Description = entity.Description;
            response.Weight = entity.Weight;
            response.UserId = entity.UserId;


            return response;
        }

        public bool DeleteProductById(int productId)
        {
            var product = this._productDomainRepository.GetProductById(productId);
            if (product == null)
            {
                return false;
            }
            this._productDomainRepository.DeleteProductById(productId);
            return true;
        }

        public GetProductResponse GetProductById(int productId)
        {

            GetProductResponse response = new GetProductResponse();

            var product = this._productDomainRepository.GetProductById(productId);
            if (product == null)
            {
                throw new Exception("Product not found!");
            }

            response.Id = productId;
            response.Name = product.Name;
            response.Weight = product.Weight;
            response.Description = product.Description;
            response.UserId = product.UserId;

            return response;
        }

        public GetProductResponse EditProductInfo(EditProductRequest request)
        {

            GetProductResponse response = new GetProductResponse();

            var product = this._productDomainRepository.GetProductById(request.Id);
            if (product == null)
            {
                throw new Exception("Product not found!");
            }
            product.Name = request.Name;
            product.Weight = request.Weight;
            product.Description = request.Description;
            product.UpdateDate = DateTime.Now;
            this._productDomainRepository.Update(product);

            response.Id = product.Id;
            response.Name = request.Name;
            response.Weight = request.Weight;
            response.Description = request.Description;
            response.UserId = product.UserId;

            return response;
        }

        public List<GetProductResponse> GetProductListByUserId(int userId)
        {

            List<GetProductResponse> response = new List<GetProductResponse>();

            var entityList = this._productDomainRepository.GetAllProductsByUserId(userId);
            foreach (var entity in entityList)
            {
                GetProductResponse dto = new GetProductResponse();
                dto.Id = entity.Id;
                dto.Name = entity.Name;
                dto.Weight = entity.Weight;
                dto.Description = entity.Description;
                dto.UserId = entity.UserId;
                response.Add(dto);
            }
            return response;
        }
    }
}
