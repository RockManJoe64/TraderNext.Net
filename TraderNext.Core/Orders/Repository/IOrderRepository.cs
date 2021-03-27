﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TraderNext.Data.Relational;
using TraderNext.Models;

namespace TraderNext.Orders.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> CreateOrderAsync(Order order);

        Task<IEnumerable<Order>> GetAllOrdersAsync();

        Task<Order> GetByOrderIdAsync(string orderId);
    }
}