using System;

namespace DataAccessLayer.Entities;

public class WebhookDeliveryAttempt
{
    public Guid Id { get; set; }
    public Guid WebhookSubscriptionId { get; set; }
    public WebhookSubscription WebhookSubscription { get; set; }
    public string Payload { get; set; }
    public int? ResponseStatusCode { get; set; }
    public bool Success { get; set; }
    public DateTime TimeStamp { get; set; }
}
