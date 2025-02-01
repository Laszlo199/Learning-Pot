using System;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Interfaces.IRepositories;

public interface IOrderRepository
{
    Task<Order> CreateOrder(Order order);
    Task<IEnumerable<Order>> GetAllOrder();
}
