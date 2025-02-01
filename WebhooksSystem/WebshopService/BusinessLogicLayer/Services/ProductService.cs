using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services;

public class ProductService : IOrderService
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
