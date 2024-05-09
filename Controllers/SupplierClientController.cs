using MegaventoryCart.Models.SupplierClient;
using MegaventoryCart.Services.SupplierClient;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierClientController : ControllerBase
    {
        private readonly ISupplierClientService _supplierClientService;
        public SupplierClientController(IConfiguration configuration, ISupplierClientService supplierClientService)
        {
            _supplierClientService = supplierClientService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSupplierClient(SupplierClientResult newSupplyClient)
        {
            var response = await _supplierClientService.UpdateSupplierClient(newSupplyClient);

            return Ok(response);
        }
    }
}
