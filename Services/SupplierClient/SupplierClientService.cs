using MegaventoryCart.Models.SupplierClient;
using MegaventoryCart.Services;
using MegaventoryCart.Services.SupplierClient;

namespace MegaventoryCart.Services.SupplierClientService
{
    public class SupplierClientService : ISupplierClientService
    {
        private string? apiEndpoint;
        private readonly string productEndpoint = "SupplierClient/SupplierClientUpdate/";
        private readonly string? apiKey;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public SupplierClientService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            apiEndpoint = _configuration["Megaventory:ApiEndpoint"];
            apiKey = _configuration["Megaventory:ApiKey"];
            apiEndpoint = $"{apiEndpoint}{productEndpoint}?APIKEY={apiKey}";

        }

        public async Task<object> UpdateSupplierClient(SupplierClientResult newSupplierClient)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync(apiEndpoint, newSupplierClient);
                httpResponseMessage.EnsureSuccessStatusCode();
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException ex)
            {
                return ex;
            }
        }
    }
}
