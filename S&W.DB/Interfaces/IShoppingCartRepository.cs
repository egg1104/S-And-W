using S_W_HealthStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_W_HealthStore.Models;
namespace S_W.DB.Interfaces
{
    public interface IShoppingCartRepository
    {
        //adding item to shopping cart 
        ShoppingCartItems AddToCart(int SHoppingCardId, int ProductId, int quantity);
        //clearing the shopping cart
        int ClearCart(int shoppingCartId);
        //getting the total of the shopping cart
        decimal GetTotal(int ShoppingCartId);
        //Get Products by shopping cart id and return them in a list of ShoppingCartItem
        List<ShoppingCartItems> GetProducts(int shoppingCartId);
        //shows the items ordered by ShoppingCartId
        void Ordered(int shoppingCartId);
        //updates the ShoppingCartItem 
        int Update(ShoppingCartItems entity);
        //adds items to shoppingCartItem
        int Add(ShoppingCartItems entity);

    }
}
