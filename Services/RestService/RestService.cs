namespace MegaventoryCart.Services.RestService
{
    public class RestService : IRestService
    {
        private readonly string? apiKey;
        private string? apiEndpoint;

        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        public RestService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            apiEndpoint = _configuration["Megaventory:ApiEndpoint"];
            apiKey = _configuration["Megaventory:ApiKey"];
        }

        public async Task<object> Post(string uri, object body)
        {
            string url = $"{apiEndpoint}{uri}?APIKEY={apiKey}";

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync(url, body);
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
