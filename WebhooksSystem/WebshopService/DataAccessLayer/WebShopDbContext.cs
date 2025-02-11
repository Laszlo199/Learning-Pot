using System;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class WebShopDbContext : DbContext
{
    public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<WebhookSubscription> WebhookSubscriptions { get; set; }
    public DbSet<WebhookDeliveryAttempt> WebhookDeliveryAttempts { get; set; }
}
