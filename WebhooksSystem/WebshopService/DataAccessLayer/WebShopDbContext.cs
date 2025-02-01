using System;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class WebShopDbContext : DbContext
{
    public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> customers {get; set;}
    public DbSet<Order> orders {get; set;}
    public DbSet<OrderItem> orderItems {get; set;}
    public DbSet<Product> products {get; set;}
}
