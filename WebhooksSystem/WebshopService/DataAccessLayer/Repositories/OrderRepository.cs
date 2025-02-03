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
        var sql = "INSERT INTO Order (Name, OrderItems, CustomerId, Customer) VALUES(@p0, @p1, @p2, @p3)";
        await _context.Database
        .ExecuteSqlRawAsync(
            sql,
            order.Name,
            order.OrderItems,
            order.CustomerId,
            order.Customer
        );
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task<IEnumerable<Order>> GetAllOrder()
    {
        return await _context.Orders
        .FromSqlRaw($"SELECT Id, Name, OrderItems, CustomerId, Customer FROM Order")
        .ToListAsync();
    }
}
