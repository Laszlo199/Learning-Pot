using System;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Interfaces.IServices;

public interface IWebhookSubscriptionService
{
    Task<WebhookSubscription> CreateSubscription(WebhookSubscription subscription);
}
