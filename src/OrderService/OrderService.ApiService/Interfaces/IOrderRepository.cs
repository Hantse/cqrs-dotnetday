using OrderService.ApiService.Contracts.Response;

namespace OrderService.ApiService.Interfaces
{
    public interface IOrderRepository
    {
        List<OrderItemResponse> QueryAll();
        int Add(OrderItemResponse orderItemResponse);
    }
}
