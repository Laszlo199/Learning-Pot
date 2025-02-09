using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces.IRepositories;

public interface IWebhookSubscriptionRepository
{
    Task<WebhookSubscription> createSubscription(WebhookSubscription subscription);
}
