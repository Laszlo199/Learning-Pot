using System;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class WebhookSubscriptionRepository : IWebhookSubscriptionRepository
{
    private readonly WebShopDbContext _context;
    public WebhookSubscriptionRepository(WebShopDbContext context)
    {
        _context = context;
    }

    public async Task<WebhookSubscription> createSubscription(WebhookSubscription subscription)
    {
        var sql = @"INSERT INTO WebhookSubscription (Url, EventType, CreatedOn, CustomerId)
                    VALUES (@s0, @s1, @s2, @s3)";
        await _context.Database
        .ExecuteSqlRawAsync(sql, 
        subscription.Url, 
        subscription.EventType, 
        DateTime.UtcNow, 
        subscription.CustomerId);

        return subscription;
    }
}
