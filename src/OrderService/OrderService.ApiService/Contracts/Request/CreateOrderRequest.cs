using System.Text.Json.Serialization;

namespace OrderService.ApiService.Contracts.Request
{
    public class CreateOrderRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
