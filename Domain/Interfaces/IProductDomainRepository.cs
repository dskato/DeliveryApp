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
        bool CreateProduct(OrderEntity entity);
        bool UpdateProduct(OrderEntity entity);
        bool GetProductById(int id);
        bool DeleteProductById(int id);
    }
}
