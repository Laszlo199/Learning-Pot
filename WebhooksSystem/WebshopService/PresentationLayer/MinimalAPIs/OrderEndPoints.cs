using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;

namespace PresentationLayer.MinimalAPIs;

public static class OrderEndPoints
{
public static void MapOrderEndPoints(this IEndpointRouteBuilder app)
    {
        var product = app.MapGroup("orders");

        product.MapGet("/", GetAll);
        product.MapPost("/", Create);
    }

    static async Task<IResult> GetAll(IOrderService service)
    {
        var orders = await service.GetAllOrder();
        return TypedResults.Ok(orders);
    }
    
    static async Task<IResult> Create(IOrderService service, Order order)
    {
        var newOrder = new Order
        {
            OrderItems = order.OrderItems,
            Status = order.Status,
            CustomerId  = order.CustomerId
        };

        await service.CreateOrder(newOrder);

        return TypedResults.Created($"Orders send successfully.");
    }
    
}
