using System;

namespace DataAccessLayer.Entities;

public class WebhookSubscription
{
    public Guid Id { get; set; }
    public string Url { get; set; }
    public string EventType { get; set; }
    public Guid CustomerId { get; set; }
}
