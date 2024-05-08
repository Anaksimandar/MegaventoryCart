using MegaventoryCart.Models;
using MegaventoryCart.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace MegaventoryCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly string? apiKey;
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductResult newProduct)
        {
            var response = await _productService.UpdateProduct(newProduct);

            return Ok(response);
        }

       
    }
}
