using MegaventoryCart.Models.Relationships.ProductSupplier;
using MegaventoryCart.Services.ProductSupplierRelationship;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSupplierController : ControllerBase
    {
        private readonly string? apiKey;
        private readonly IProductSupplierRelationshipService _productSupplierService;
        public ProductSupplierController(IProductSupplierRelationshipService productSupplierService)
        {
            _productSupplierService = productSupplierService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductSupplier(ProductSupplierRelationshipResult newProductSupplier)
        {
            var response = await _productSupplierService.UpdateProductSupplier(newProductSupplier);

            return Ok(response);
        }
    }
}
