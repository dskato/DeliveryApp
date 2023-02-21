using API.DTOs.Orders;

namespace API
{
    public partial interface IApplicationService
    {
        CreateOrderResponse CreateOrder(CreateOrderRequest request);
        bool DeleteOrderById(int orderId);
        GetOrderResponse GetOrderById(int orderId);
        List<GetOrderResponse> GetAllOrders();
        GetOrderResponse EditOrderInfo(EditOrderRequest request);

    }
}