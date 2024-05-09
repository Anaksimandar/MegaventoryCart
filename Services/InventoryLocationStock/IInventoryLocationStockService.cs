using MegaventoryCart.Models.InventoryLocationStock;

namespace MegaventoryCart.Services.InventoryLocationStock
{
    public interface IInventoryLocationStockProvider
    {
        Task<object> UpdateInventoryLocationStock(InventoryLocationStockResult newInventoryLocationStockResult);
    }
}
