using System;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly WebShopDbContext _context;

    public OrderRepository(WebShopDbContext context)
    {
        _context = context;
    }
    public async Task<Order> CreateOrder(Order order)
    {
        var sql = @"INSERT INTO Orders (OrderItems, Status, CustomerId) 
                    VALUES(@p0, @p1, @p2)";
        await _context.Database
        .ExecuteSqlRawAsync(
            sql,
            order.OrderItems,
            order.Status,
            order.CustomerId
        );

        foreach(var item in order.OrderItems)
        {
            var sqlOrderItem = @"INSERT INTO OrderItems (OrderItemId, OrderId, ProductId, Quantity, Price) 
                            VALUES (@p0, @p1, @p2, @p3, @p4)";
                            
            await _context.Database.ExecuteSqlRawAsync(sqlOrderItem, item.OrderItemId, order.Id, item.ProductId, item.Quantity, item.Price);
        }
        
        return order;

    }

    public async Task<IEnumerable<Order>> GetAllOrder()
    {
        var sql = @"SELECT o.Id, o.Status, o.CustomerId, oi.OrderItemId, oi.ProductId, oi.Quantity, oi.Price
                FROM Orders o
                LEFT JOIN OrderItems oi ON o.Id = oi.OrderId";

        var result = await _context.Orders
            .FromSqlRaw(sql)
            .AsNoTracking()
            .ToListAsync();

        return result;
    }
}
