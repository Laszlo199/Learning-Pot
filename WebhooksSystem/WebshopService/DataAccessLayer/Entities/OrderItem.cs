using System;

namespace DataAccessLayer.Entities;

public class OrderItem
{
    public Guid OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
}
