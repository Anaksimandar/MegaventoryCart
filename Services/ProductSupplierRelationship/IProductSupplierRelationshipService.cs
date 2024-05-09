using MegaventoryCart.Models.Relationships.ProductSupplier;

namespace MegaventoryCart.Services.ProductSupplierRelationship
{
    public interface IProductSupplierRelationshipService
    {
        Task<object> UpdateProductSupplier(ProductSupplierRelationshipResult newProductSupplier);
    }
}
