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

    public async Task<WebhookSubscription> CreateSubscription(WebhookSubscription subscription)
    {
        subscription.Id = Guid.NewGuid();
        subscription.CreateOn = DateTime.UtcNow;

        var sql = @"INSERT INTO WebhookSubscriptions (Id, Url, EventType, CreatedOn)
                    VALUES (@s0, @s1, @s2, @s3)";
                    
        await _context.Database
        .ExecuteSqlRawAsync(
            sql,
            subscription.Id,
            subscription.Url, 
            subscription.EventType, 
            subscription.CreateOn
        );

        return subscription;
    }

    public async Task<IEnumerable<WebhookSubscription>> GetSubscriptionByEventType(string eventType)
    {
        var sql = @"SELECT Id, Url, EventType, CreateOn FROM WebhookSubscriptions 
                    WHERE EventType = @e0";

        var result = await _context.WebhookSubscriptions
            .FromSqlRaw(sql, eventType)
            .AsNoTracking()
            .ToListAsync();

        return result;
    }
}
