using System;

namespace DataAccessLayer.Entities;

public class Order
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
