using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;

namespace BusinessLogicLayer.Services;

public class WebhookSubscriptionService : IWebhookSubscriptionService
{
    private readonly IWebhookSubscriptionRepository _subscriptionRepository;

    public WebhookSubscriptionService(IWebhookSubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
    }
    public async Task<WebhookSubscription> CreateSubscription(WebhookSubscription subscription)
    {
        return await _subscriptionRepository.CreateSubscription(subscription);
    }
}
