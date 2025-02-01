using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<Order> CreateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Order>> GetAllOrder()
    {
        throw new NotImplementedException();
    }
}
