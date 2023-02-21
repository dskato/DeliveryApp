using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class OrderRepository : GenericDataDbRepository<OrderEntity>, IOrderDomainRepository
    {
        public OrderRepository(AppDbContext contex) : base(contex)
        {
            Context = contex;
        }

        public int CreateOrder(OrderEntity entity)
        {
            this.AddSync(entity);
            return entity.Id;
        }

        public void DeleteOrderById(int id)
        {
            OrderEntity order = this.GetOrderById(id);
            this.RemoveSync(order);
        }

        public OrderEntity GetOrderById(int id)
        {
            OrderEntity entity = this.Context.OrderEntity.Include(x => x.Product).Include(x => x.RequestingUser).Include(x => x.CourierUser).Where(x => x.Id == id).FirstOrDefault();
            return entity;
        }

        public List<OrderEntity> GetAllOrders() { 
            var list = this.Context.OrderEntity.Include(x => x.Product).Include(x => x.RequestingUser).Include(x => x.CourierUser).ToList();
            return list;
        }
    }
}
