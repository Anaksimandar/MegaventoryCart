using MegaventoryCart.Models;
using MegaventoryCart.Models.InventoryLocation;
using MegaventoryCart.Services.InventoryLocation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryLocationController : ControllerBase
    {
        private readonly string? apiKey;
        private readonly IConfiguration _configuration;
        private readonly IInventoryLocationService _inventoryLocationService;
        public InventoryLocationController(IConfiguration configuration, IInventoryLocationService inventoryLocationService) {
            _inventoryLocationService = inventoryLocationService;
            _configuration = configuration;
            apiKey = configuration["Megaventory:ApiKey"];
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInventoryLocation(InventoryLocationResult newInventoryLocation)
        {
            var response = await _inventoryLocationService.UpdateInventoryLocation(newInventoryLocation); ;

            return Ok(response);
        }
    }
}
