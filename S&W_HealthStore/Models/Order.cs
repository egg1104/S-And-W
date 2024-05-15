using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_W_HealthStore.Models
{
    public class Order
    {
        //int Variable Named OrderId
        public int OrderId { get; set; }
        //String Variable Named OrderNumber
        public string OrderNumber { get; set; }
        //int Variable Named CustomerId
        public int CustomerId { get; set; }
        //int Variable Named ShoppingCartId
        public int ShoppingCartId { get; set; }
    }
}
