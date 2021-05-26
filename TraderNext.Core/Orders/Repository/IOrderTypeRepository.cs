﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TraderNext.Core.Data;
using TraderNext.Core.Models;

namespace TraderNext.Core.Orders.Repository
{
    public interface IOrderTypeRepository : IRepository<OrderType>
    {
        IEnumerable<OrderType> GetAllOrderTypes();
    }
}
