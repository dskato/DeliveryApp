using Domain.Entities;
using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOrderDomainRepository : IGenericDataRepository<OrderEntity>
    {
        int CreateOrder(OrderEntity entity);
        OrderEntity GetOrderById(int id);
        void DeleteOrderById(int id);
        List<OrderEntity> GetAllOrders();

    }
}
