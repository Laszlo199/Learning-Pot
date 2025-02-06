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
        var sql = @"INSERT INTO Orders (CostumerName, Status, OrderDate) 
                    VALUES(@p0, @p1, @p2)";
        await _context.Database
        .ExecuteSqlRawAsync(
            sql,
            order.CostumerName,
            order.Status,
            order.OrderDate
        );

        return order;

    }

    public async Task<IEnumerable<Order>> GetAllOrder()
    {
        var sql = @"SELECT Id, CostumerName, Status, oi.OrderItemId, OrderDate
                FROM Orders";

        var result = await _context.Orders
            .FromSqlRaw(sql)
            .AsNoTracking()
            .ToListAsync();

        return result;
    }
}
