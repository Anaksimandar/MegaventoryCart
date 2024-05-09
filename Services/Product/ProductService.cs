using MegaventoryCart.Models.Product;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IRestService _restService;
        public ProductService(IRestService restService)
        {
            _restService = restService;

        }
        public async Task<object> UpdateProduct(ProductResult newProduct)
        {
            var response = await _restService.Post("Product/ProductUpdate/", newProduct);

            return response;
        }

     
    }
}
