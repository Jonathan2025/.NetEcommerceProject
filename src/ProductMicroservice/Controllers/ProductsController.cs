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
        // We create a static list to prevent the list being recreated everytime someone interacts with it 
        private static readonly List<ProductDto> products = new()
        {
            // Now here we can add an actual product
            new ProductDto(Guid.NewGuid(), "Battlefield 5", "The latest battlefield game from EA", 60, DateTimeOffset.UtcNow)
        };


        
    }
}