using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;

namespace PresentationLayer.MinimalAPIs;

public static class SubscriptionEndPoints
{
    public static void MapSubscriptionEndPoints(this IEndpointRouteBuilder app)
    {
        var subscription = app.MapGroup("subscription");

        subscription.MapPost("/", Create);
    }

    static async Task<IResult> Create(IWebhookSubscriptionService service, WebhookSubscription subscription)
    {
        var newSubscription = new WebhookSubscription
        {
            Url = subscription.Url,
            EventType = subscription.EventType,
            //CreateOn  = subscription.CreateOn
            CustomerId = subscription.CustomerId
        };

        await service.createSubscription(newSubscription);

        return TypedResults.Created($"Subscription created successfully created at {subscription.CreateOn} for the {subscription.EventType}.");
    }

}
