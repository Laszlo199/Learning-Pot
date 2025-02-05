using System;
using DataAccessLayer.Enums;

namespace DataAccessLayer.Entities;

public class Order
{
    public Guid Id { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public OrderStatus Status { get; set; }
    public Guid CustomerId { get; set; }
}
