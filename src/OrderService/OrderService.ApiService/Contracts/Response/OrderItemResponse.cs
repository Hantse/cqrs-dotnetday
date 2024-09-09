using System.Text.Json.Serialization;

namespace OrderService.ApiService.Contracts.Response
{
    public class OrderItemResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
