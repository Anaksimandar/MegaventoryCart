using MegaventoryCart.Models;

namespace MegaventoryCart.Services.ProductService
{
    public interface IProductService
    {
        Task<object> UpdateProduct(ProductResult newProduct);
    }
}
