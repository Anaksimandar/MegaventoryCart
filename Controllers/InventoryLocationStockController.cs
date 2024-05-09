using MegaventoryCart.Models.InventoryLocationStock;
using MegaventoryCart.Services.InventoryLocationStock;
using MegaventoryCart.Services.RestService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryLocationStockController : ControllerBase
    {
        private readonly IInventoryLocationStockProvider _inventoryLocationStockProvider;

        public InventoryLocationStockController(IInventoryLocationStockProvider inventoryLocationStockProvider)
        {
            _inventoryLocationStockProvider = inventoryLocationStockProvider;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInventoryLocationStock(InventoryLocationStockResult newInventoryLocationStockResult)
        {
            var result = await _inventoryLocationStockProvider.UpdateInventoryLocationStock(newInventoryLocationStockResult);

            return Ok(result);
        }
    }
}
