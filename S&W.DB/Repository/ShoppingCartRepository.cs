using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using S_W.DB.Interfaces;
using S_W_HealthStore.Models;

namespace S_W.DB.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        //allows to you to use iconnectionFactory in this repository and establish a connection to the sql database
        private IConnectionFactory _connectionFactory;

        //Constructor setting _connectionFactory = conn 
        public ShoppingCartRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        //Adding values to the shoppingcartItem Table
        public int Add(ShoppingCartItems entity)
        {
            //sql statement that adds values to the ShoppingCartItems Table
            var sql = "insert into ShoppingCartItems (ShoppingCartId,ProductId,Quantity) VALUES ( @ShoppingCartId, @ProductId, @Quantity)";
            //establishes connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opens connection
                connection.Open();
                //excutes the sql statement and takes a object of shoppingcartItem
                var result = connection.Execute(sql, entity);
                //return results
                return result;
            }
        }

        //Add items to the cart method returning a ShoppingCartItem
        public ShoppingCartItems AddToCart(int ShoppingCardId, int ProductId, int quantity)
        {
            //establishes a connection to sql database
            using (var conn = _connectionFactory.GetConnection)
            {
                //creates a product Repository ands connects it to database
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);
                //creating item variable and having it get product by productid
                var item = _productRepository.GetById(ProductId);
                //creating productitems variable then we are finding products by shoppingCardId then we find product by its id and set it to ProductId
                var ProductItems = GetProducts(ShoppingCardId).Find(x => x.ProductId == ProductId);

                //creates a new object of ShoppingCartItem called shopitem and settings its values equal to the ones in the methods paramaters
                var shopitem = new ShoppingCartItems()
                {
                    ShoppingCartId = ShoppingCardId,
                    ProductId = ProductId,
                    Quantity = quantity
                };

                //if items Quantity is greater than or equal to the quantity passed in code continues
                if (item.Quantity >= quantity)
                {
                    //if ProductItems is not null then code continues
                    if (ProductItems != null)
                    {
                        //Product already in cart so update quantity
                        var test = Update(shopitem);
                    }
                    else
                    {
                        // adds new shop item
                        var test = Add(shopitem);


                    }
                }
                //returns shop item
                return shopitem;
            }
        }

        //this is deleteing all items from the cart
        public int ClearCart(int shoppingCartId)
        {
            // sql statement delete values from shoppingcartitems where shoppingcart id is equal to the one passed in
            var sql = "DELETE from ShoppingCartItems where ShoppingCartId = @ShoppingCartId";
            //establishing connection to database
            using (var connection = _connectionFactory.GetConnection)
            {
                //opening connection
                connection.Open();
                //excuting sql statement and setting the method parameter to ShoppingCartId
                var result = connection.Execute(sql, new { ShoppingCartId = shoppingCartId });
                //returning the results
                return result;
            }
        }

        //Getting Products by shopping cart id
        public List<ShoppingCartItems> GetProducts(int shoppingCartId)
        {
            //sql statement that returns ProductId from ShoppingCartItems where the shoppingCartId = to the id passed in
            var sql = "SELECT ProductId FROM ShoppingCartItems where ShoppingCartId = @shoppingCartId";
            //establishing a connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opens connection
                connection.Open();
                //excutes the sql statement and then add the productId to a shoppingCartItem Object and then setting shoppingCartId = the methods parameter shoppingCartId
                var result = connection.Query<ShoppingCartItems>(sql, new { shoppingCartId = shoppingCartId }).ToList();
                //return results
                return result;
            }

        }

        //this method gathers the total and returns a decimal
        public decimal GetTotal(int shoppingCartId)
        {
            //sql statement that gets the sum of Price * ShoppingCartItems.Quantity and to do this it used a equi join to link products table and ShoppingCartItems Table it also is making sure ShoppingCartId is = to the id passed in
            var sql = "SELECT SUM(Price * ShoppingCartItems.Quantity) FROM Products JOIN ShoppingCartItems ON ProductId = Products.Id WHERE ShoppingCartId = @shoppingCartId";
            //establishing a connection 
            using (var connection = _connectionFactory.GetConnection)
            {
                //opening the connection
                connection.Open();
                //excutes the sql statement and grabs the results and stores it in a decimal list if its not null
                var result = connection.QueryFirstOrDefault<decimal?>(sql, new { shoppingCartId = shoppingCartId });
                //if result is not null then code continues
                if (result != null)
                {
                    //returns result
                    return (decimal)result;
                }
                else
                {
                    // returns 0 if its null
                    return 0;
                }




            }
        }

        //method made to store ordered history
        public void Ordered(int shoppingCartId)
        {
            //for now it just deletes the values in shoppingCartItems Table
            var sql = "DELETE * from ShoppingCartItems where ShoppingCartId = @ShoppingCartId";
            //establishes the connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //Opens connection
                connection.Open();
                //excutes sql statement and sets ShoppingCartId to the Parameter shoppingCartId
                var result = connection.Execute(sql, new { ShoppingCartId = shoppingCartId });

            }
        }

        //method updates ShoppingCartItemTable
        public int Update(ShoppingCartItems entity)
        {
            //sql statement that Updates the values in ShoppingCartItems table
            var sql = "UPDATE ShoppingCartItems SET ShoppingCartId = @ShoppingCartId, ProductId = @ProductId, Quantity = @Quantity Where ShoppingCartId = @ShoppingCartId AND ProductId = @ProductId";
            //establishes connection from database
            using (var connection = _connectionFactory.GetConnection)
            {
                //open connection
                connection.Open();
                //excutes the sql statement and sets the values from shoppingcartitem object to the database
                var result = connection.Execute(sql, entity);
                //return results
                return result;
            }
        }
    }
}
