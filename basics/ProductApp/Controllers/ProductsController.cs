﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllProducts() 
        {
            var products = new List<Product>() 
            {
             new Product() { Id = 1,Name="Laptop"},
             new Product() { Id = 2,Name="Keyboard"},
             new Product() {Id = 3,Name="Mouse" }
            };
            logger.LogInformation("GetAllProducts Action Has Been Called");
            return Ok(products);
        }
    }
}
