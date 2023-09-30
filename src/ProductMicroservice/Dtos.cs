// This file will contain the DTOs (Data Transfer Objects) - more specifically using record types 
// In the scheme of a microservice, with a DTO we are essentially specifying a format of the data that is being transferred between parts of the application
// Record types offer more readibility and immutability 


using System;


namespace ProductMicroservice.Dtos
{
    // Guid is Global unique identifier
    public record ProductDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    // Next DTO is the creation of the item/product
    // The time and the id will automatically be generated so we dont need to specify it here 
    public record CreateProductDto( string Name, string Description, string Price);


    // Then we want a DTO for updating an item/product     
    public record UpdateProductDto(string Name, string Description, string Price);
}