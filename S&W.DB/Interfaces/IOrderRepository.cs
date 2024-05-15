using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_W_HealthStore.Models;

namespace S_W.DB.Interfaces
{
    public interface IOrderRepository : IgenericRepository<Order>
    {
        //method to get order by customer id
        Order GetOrderByCustomerId(int id);
    }
}
