using MegaventoryCart.Models.Product;
using MegaventoryCart.Models.Relationships.ProductClientRelationship;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.ProductClient
{
    public class ProductClientRelationshipService : IProductClientRelationshipService
    {
        private readonly IRestService _restService;
        public ProductClientRelationshipService(IRestService restService)
        {
            _restService = restService;
        }
        public async Task<object> UpdateProductClient(ProductClientRelationshipResult newProductClientRelationship)
        {
            var response = await _restService.Post("ProductClient/ProductClientUpdate/", newProductClientRelationship);

            return response;

        }
    }
}
