using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericDataDbRepository<ProductEntity>, IProductDomainRepository
    {
        public ProductRepository(AppDbContext contex) : base(contex)
        {
            Context = contex;
        }

        public int CreateProduct(ProductEntity entity)
        {
            this.AddSync(entity);
            return entity.Id;
        }

        public void  DeleteProductById(int id)
        {
            ProductEntity productEntity = this.GetProductById(id);
            this.RemoveSync(productEntity);
        }

        public ProductEntity GetProductById(int id)
        {
            ProductEntity entity = this.Context.ProductEntity.Where(x => x.Id == id).FirstOrDefault();
            return entity;
        }

        public List<ProductEntity> GetAllProductsByUserId(int userId) { 

            var productList = this.Context.ProductEntity.Where(x => x.UserId == userId).ToList();
            return productList;

        }


    }
}
