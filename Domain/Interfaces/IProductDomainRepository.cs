using Domain.Entities;
using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductDomainRepository : IGenericDataRepository<ProductEntity>
    {
        int CreateProduct(ProductEntity entity);
        ProductEntity GetProductById(int id);
        void DeleteProductById(int id);
        List<ProductEntity> GetAllProductsByUserId(int userId);
    }
}
