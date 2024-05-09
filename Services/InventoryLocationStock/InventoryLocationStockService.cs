using MegaventoryCart.Models.InventoryLocationStock;
using MegaventoryCart.Services.RestService;

namespace MegaventoryCart.Services.InventoryLocationStock
{
    public class InventoryLocationStockService : IInventoryLocationStockProvider
    {
        private readonly IRestService _restService;
        public InventoryLocationStockService(IRestService restService) {
            _restService = restService;
        }
        public async Task<object> UpdateInventoryLocationStock(InventoryLocationStockResult newInventoryLocationStockResult)
        {
            var response = await _restService.Post("InventoryLocationStock/ProductStockUpdate/", newInventoryLocationStockResult);

            return response;
        }
    }
}
