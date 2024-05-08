using MegaventoryCart.Models.InventoryLocation;

namespace MegaventoryCart.Services.InventoryLocation
{
    public interface IInventoryLocationService
    {
        Task<object> UpdateInventoryLocation(InventoryLocationResult newInventoryLocation);
    }
}
