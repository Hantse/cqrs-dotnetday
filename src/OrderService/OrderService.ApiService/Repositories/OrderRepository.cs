using OrderService.ApiService.Contracts.Response;
using OrderService.ApiService.Interfaces;

namespace OrderService.ApiService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private static List<OrderItemResponse> orders = new List<OrderItemResponse>();


        public List<OrderItemResponse> QueryAll() => orders;

        public int Add(OrderItemResponse orderItemResponse)
        {
            orders.Add(orderItemResponse);
            return orderItemResponse.Id;
        }
    }
}
