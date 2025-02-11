using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces.IRepositories;

public interface IWebhookSubscriptionRepository
{
    Task<WebhookSubscription> CreateSubscription(WebhookSubscription subscription);
    Task<IEnumerable<WebhookSubscription>> GetSubscriptionByEventType(string eventType);
}
