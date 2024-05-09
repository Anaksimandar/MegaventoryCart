using MegaventoryCart.Models.Product;
using MegaventoryCart.Models.Relationships.ProductSupplier;
using MegaventoryCart.Services.ProductSupplierRelationship;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.ProductClient
{
    public class ProductSupplierRelationshipService : IProductSupplierRelationshipService
    {
        private readonly IRestService _restService;
        public ProductSupplierRelationshipService(IRestService restService)
        {
            _restService = restService;
        }
        public async Task<object> UpdateProductSupplier(ProductSupplierRelationshipResult newProductClientRelationship)
        {
            var response = await _restService.Post("ProductSupplier/ProductSupplierUpdate/", newProductClientRelationship);

            return response;

        }
    }
}
