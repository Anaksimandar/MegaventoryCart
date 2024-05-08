using MegaventoryCart.Models;
using MegaventoryCart.Models.InventoryLocation;
using MegaventoryCart.Services.InventoryLocation;

namespace MegaventoryCart.Services.InventoryLocationService
{
    public class InventoryLocationService : IInventoryLocationService
    {
        private string? apiEndpoint;
        private readonly string productEndpoint = "InventoryLocation/InventoryLocationUpdate/";
        private readonly string? apiKey;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public InventoryLocationService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            apiEndpoint = _configuration["Megaventory:ApiEndpoint"];
            apiKey = _configuration["Megaventory:ApiKey"];
            apiEndpoint = $"{apiEndpoint}{productEndpoint}?APIKEY={apiKey}";

        }
        public async Task<object> UpdateInventoryLocation(InventoryLocationResult newInventoryLocation)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync(apiEndpoint, newInventoryLocation);
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
