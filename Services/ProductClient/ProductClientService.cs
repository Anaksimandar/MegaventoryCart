using MegaventoryCart.Models.Product;
using MegaventoryCart.Models.ProductClient;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.ProductClient
{
    public class ProductClientService : IProductClient
    {
        private readonly IRestService _restService;
        public ProductClientService(IRestService restService)
        {
            _restService = restService;
        }
        public async Task<object> UpdateProductClient(ProductClientResult newProductClientRelationship)
        {
            var response = await _restService.Post("ProductClient/ProductClientUpdate/", newProductClientRelationship);

            return response;

        }
    }
}
