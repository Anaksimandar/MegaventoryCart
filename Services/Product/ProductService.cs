
using MegaventoryCart.Models;
using System.Net.Http;

namespace MegaventoryCart.Services.ProductService
{
    public class ProductService : IProductService
    {
        private string? apiEndpoint;
        private readonly string productEndpoint = "Product/ProductUpdate/";
        private readonly string? apiKey;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            apiEndpoint = _configuration["Megaventory:ApiEndpoint"];
            apiKey = _configuration["Megaventory:ApiKey"];
            apiEndpoint = $"{apiEndpoint}{productEndpoint}?APIKEY={apiKey}";

        }
        public async Task<object> UpdateProduct(ProductResult newProduct)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync(apiEndpoint, newProduct);
                httpResponseMessage.EnsureSuccessStatusCode();
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch(HttpRequestException  ex)
            {
                return ex;
            }

        }
    }
}
