﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TraderNext.Core.Models;

namespace TraderNext.Core.Orders.Fetch
{
    public interface IFetchOrdersService
    {
        Task<IEnumerable<Order>> FetchOrdersAsync();
    }
}
