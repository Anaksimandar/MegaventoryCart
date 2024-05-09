using MegaventoryCart.Models.ProductClient;

namespace MegaventoryCart.Services.ProductClient
{
    public interface IProductClient
    {
        Task<object> UpdateProductClient(ProductClientResult newProductClient);
    }
}
