using MegaventoryCart.Models.Relationships.ProductClientRelationship;

namespace MegaventoryCart.Services.ProductClient
{
    public interface IProductClientRelationshipService
    {
        Task<object> UpdateProductClient(ProductClientRelationshipResult newProductClient);
    }
}
