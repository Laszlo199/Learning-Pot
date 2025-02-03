using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public async Task<Order> CreateOrder(Order order)
    {
        return await _orderRepository.CreateOrder(order);
    }

    public async Task<IEnumerable<Order>> GetAllOrder()
    {
        return await _orderRepository.GetAllOrder();
    }
}
