using Containerization.ProductService.Models;
using Microsoft.AspNetCore.Mvc;

namespace Containerization.ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(ILogger<ProductsController> logger) 
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = new List<Product> {
                new Product(1, "Aspire3", "Accer", "Professional Laptop", 45000),
                new Product(2, "Aspire5", "Accer", "Professional Laptop", 48000),
                new Product(3, "Aspire7", "Accer", "Professional & Gaming Laptop", 53000),
                new Product(4, "Nitro", "Accer", "Gaming Laptop", 65000),
                new Product(5, "Nitro", "Predators", "Gaming Laptop", 75000),
             };
            return await Task.FromResult(StatusCode(StatusCodes.Status200OK, products));
        }
    }
}
