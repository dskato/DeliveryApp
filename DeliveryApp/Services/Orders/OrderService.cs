using API.DTOs.Orders;
using Domain.Entities;

namespace API
{
    public partial class ApplicationService : IApplicationService
    {
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {

            CreateOrderResponse response = new CreateOrderResponse();

            OrderEntity entity = new OrderEntity();
            entity.PickUpAddress = request.PickUpAddress;
            entity.DeliveryAddress = request.DeliveryAddress;
            entity.Description = request.Description;
            entity.ProductId = request.ProductId;
            entity.RequestingUserId = request.RequestingUserId;
            entity.CourierUserId = entity.CourierUserId;

            this._orderDomainRepository.CreateOrder(entity);

            response.PickUpAddress = entity.PickUpAddress;
            response.DeliveryAddress = entity.DeliveryAddress;
            response.Description = entity.Description;
            response.ProductId = entity.ProductId;
            response.RequestingUserId = entity.RequestingUserId;
            response.CourierUserId = entity.CourierUserId;

            return response;
        }

        public bool DeleteOrderById(int orderId)
        {
            var order = this._orderDomainRepository.GetOrderById(orderId);
            if (order == null)
            {
                return false;
            }
            this._orderDomainRepository.DeleteOrderById(orderId);
            return true;
        }
        public GetOrderResponse GetOrderById(int orderId)
        {

            GetOrderResponse response = new GetOrderResponse();

            var order = this._orderDomainRepository.GetOrderById(orderId);
            if (order == null)
            {
                throw new Exception("Order not found!");
            }
            response.Id = order.Id;
            response.PickUpAddress = order.PickUpAddress;
            response.DeliveryAddress = order.DeliveryAddress;
            response.Description = order.Description;
            response.ProductId = order.ProductId;
            response.RequestingUserId = order.RequestingUserId;
            response.CourierUserId = order.CourierUserId;

            return response;
        }

        public List<GetOrderResponse> GetAllOrders()
        {

            List<GetOrderResponse> orderList = new List<GetOrderResponse>();
            var entityList = this._orderDomainRepository.GetAllOrders();

            foreach (var entity in entityList)
            {

                GetOrderResponse dto = new GetOrderResponse();
                dto.Id = entity.Id;
                dto.PickUpAddress = entity.PickUpAddress;
                dto.DeliveryAddress = entity.DeliveryAddress;
                dto.Description = entity.Description;
                dto.ProductId = entity.ProductId;
                dto.RequestingUserId = entity.RequestingUserId;
                dto.CourierUserId = entity.CourierUserId;

                orderList.Add(dto);
            }
            return orderList;
        }

        public GetOrderResponse EditOrderInfo(EditOrderRequest request)
        {
            GetOrderResponse response = new GetOrderResponse();

            var order = this._orderDomainRepository.GetOrderById((int)request.Id);
            if (order == null)
            {
                throw new Exception("Order not found!");
            }
            order.PickUpAddress = request.PickUpAddress;
            order.DeliveryAddress = request.DeliveryAddress;
            order.Description = request.Description;
            order.CourierUserId = request.CourierUserId;
            
            this._orderDomainRepository.Update(order);

            response.Id = order.Id;
            response.PickUpAddress = order.PickUpAddress;
            response.DeliveryAddress = order.DeliveryAddress;
            response.Description = order.Description;
            response.ProductId = order.ProductId;
            response.RequestingUserId = order.RequestingUserId;
            response.CourierUserId = order.CourierUserId;

            return response;
        }
    }
}
