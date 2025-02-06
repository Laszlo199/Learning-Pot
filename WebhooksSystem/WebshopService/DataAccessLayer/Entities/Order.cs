using System;
using DataAccessLayer.Enums;

namespace DataAccessLayer.Entities;

public class Order
{
    public Guid Id { get; set; }
    public required string CostumerName { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime OrderDate { get; set; }
    
}
