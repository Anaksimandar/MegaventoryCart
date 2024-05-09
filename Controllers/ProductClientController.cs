using MegaventoryCart.Models.Relationships.ProductClientRelationship;
using MegaventoryCart.Services.ProductClient;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductClientController : ControllerBase
    {
        private readonly string? apiKey;
        private readonly IProductClientRelationshipService _productClientService;
        public ProductClientController(IProductClientRelationshipService productClientService)
        {
            _productClientService = productClientService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProductClient(ProductClientRelationshipResult newProductClient)
        {
            var response = await _productClientService.UpdateProductClient(newProductClient);

            return Ok(response);
        }
    }
}
