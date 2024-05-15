using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_W.DB.Interfaces
{
    public interface IUnitOfWork
    {
        //I unit of work holds all the interfaces so you can have cleaner code when calling it to your other projects because then you only have to call it once
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IShoppingCartRepository ShoppingCarts { get; }
    }
}
