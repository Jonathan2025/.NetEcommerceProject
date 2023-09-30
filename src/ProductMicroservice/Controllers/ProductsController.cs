// This file will contain the controllers responsible for the products
// Controllers handle incoming HTTP requests and send response back to the caller 

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Dtos;

namespace ProductMicroservice.Controllers
{

    
    // For each controller we also want to add API controller - enables a series of features such as attribute routing requirement and automatic model validation
    [ApiController]
    [Route("products")] // By adding Route here, that means this controller will handle requests made to https://localhost:5001/products for example
    // Each controller will be from Controller base, because it provides ability to add in methods for HTTP requests
    public class ProductsController : ControllerBase
    {
        // We create a static list to prevent the list being recreated everytime someone invokes one of the rest API methods 
        private static readonly List<ProductDto> products = new()
        {
            // Now here we can add an actual product
            // Guid.NewGuid makes an actual guid with a unique value
            new ProductDto(Guid.NewGuid(), "Battlefield 5", "The latest battlefield game from EA", 60, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Call of Duty: Cold War", "Call of Duty Franchise Steps back into the events before Black Ops 2 in the 1980s", 60, DateTimeOffset.UtcNow),
            new ProductDto(Guid.NewGuid(), "Grand Theft Auto 5", "Rockstar Games after 10 years havent made a new GTA game so they decided stall to re-release GTA5 on new-gen consoles", 60, DateTimeOffset.UtcNow)
        };

        // This is like the get route that will return all the products
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            return products;
        }
        

        // GET /items/{id}
        // Here we want to return a SPECIFIC Item 
        // ANd we need to pass in the specific id 
        [HttpGet("{id}")]
        public ProductDto GetById(Guid id)
        {
            var product = products.Where(product => product.Id == id).SingleOrDefault(); // Get the product or return null
            return product;
        }
    }
}