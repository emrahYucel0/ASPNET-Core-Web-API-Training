using Deneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<Product> _logger;

        public ProductsController(ILogger<Product> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, Name = "Keyboard" }

            };
            logger.ogInformation("Loging work");
            return Ok(products);
        }
    }
}
