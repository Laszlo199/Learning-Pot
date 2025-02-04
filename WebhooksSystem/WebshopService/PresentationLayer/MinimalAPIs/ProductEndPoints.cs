using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;

namespace PresentationLayer.MinimalAPIs;

public static class ProductEndPoints
{
    public static void MapProductEndPoints(this IEndpointRouteBuilder app)
    {
        var product = app.MapGroup("products");

        product.MapGet("/", GetAll);
        product.MapPost("/", Create);
    }

    static async Task<IResult> GetAll(IProductService service)
    {
        var products = await service.GetAllProduct();
        return TypedResults.Ok(products);
    }
    
    static async Task<IResult> Create(IProductService service, Product product)
    {
        var newProduct = new Product
        {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            StockQuantity  = product.StockQuantity
        };

        await service.CreateProduct(newProduct);

        return TypedResults.Created($"Product '{newProduct.Name}' created successfully.");
    }
}
