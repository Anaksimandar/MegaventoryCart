using MegaventoryCart.Models.InventoryLocation;
using MegaventoryCart.Services.InventoryLocation;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.InventoryLocationService
{
    public class InventoryLocationService : IInventoryLocationService
    {
        private readonly IRestService _restService;

        public InventoryLocationService(IRestService restService)
        {
            _restService = restService;
        }
        public async Task<object> UpdateInventoryLocation(InventoryLocationResult newInventoryLocation)
        {
            var response = await _restService.Post("InventoryLocation/InventoryLocationUpdate/", newInventoryLocation);

            return response;

        }
    }
}
