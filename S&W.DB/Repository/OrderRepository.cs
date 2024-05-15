using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_W.DB.UOW;
using S_W.DB.Interfaces;
using S_W_HealthStore.Models;
using Dapper;
namespace S_W.DB.Repository
{
    public class OrderRepository:IOrderRepository
    {

        //making it so we can use IConnectionFactory on this repository so we can connect to the sql database
        private readonly IConnectionFactory _connectionFactory;

        //Constructor setting conn = to the _connectionFactory
        public OrderRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        //Adds values to the order table
        public int Add(Order entity)
        {
            //sql statement that inserts the values into orders table
            var sql = "Insert into Orders (OrderId, OrderNumber,CustomerId,ShoppingCartId) Values(@OrderId,@OrderNumber,@CustomerId,@ShoppingCartId)";
            //establishing the connection to database
            using (var connection = _connectionFactory.GetConnection)
            {
                //open the connection
                connection.Open();
                //excuting the sql statement and placeing the order object from the method parameter in there
                var results = connection.Execute(sql, entity);
                //return the results
                return results;
            }
        }

        //deletes values to the order table
        public int Delete(int id)
        {
            //sql statement that is deleteing the values from order table where orderId = id that is passed in
            var sql = "Delete FROM Orders WHERE OrderId = @OrderId";

            //establishes the connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opens the connection
                connection.Open();
                //excutes the sql statement and sets the OrderId to the methods parameters id
                var results = connection.Execute(sql, new { OrderId = id });
                //returns the results
                return results;
            }
        }
        //Gets all values from the orders table and stores them in a orders list
        public List<Order> GetAll()
        {
            //sql statement to get all values from orders table
            var sql = "Select * From Orders";
            //establishing connection to the database
            using (var connection = _connectionFactory.GetConnection)
            {
                //opens the connection
                connection.Open();
                //this is pulling values from the database by excuting the sql statement and storeing the order objects to a list
                var results = connection.QuerySingleOrDefault<List<Order>>(sql);
                //return results
                return results;
            }
        }

        //Retrieve the item from order table by Order id
        public Order GetById(int id)
        {
            //sql statement getting all values from orders where orderId is equil the id passed in
            var sql = $"Select * From Orders where OrderId = {id}";
            //establishing the connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opening the connection
                connection.Open();
                //pulling the values from order table by excuting the sql statement and setting orderId to method parameter id
                var results = connection.QuerySingleOrDefault<Order>(sql, new { OrderId = id });
                //returns results
                return results;
            }
        }

        //Gets item from order table by Customer id
        public Order GetOrderByCustomerId(int id)
        {
            //sql statement that gets all from orders table where the customer id = to the id that is passed in to the method parameter
            var sql = "Select * From Orders where CustomerId = @CustomerId";
            //establishing a connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opening the connection
                connection.Open();
                //pulling out values from the orders table by excuting the sql statement and setting customerId = the method parameter id 
                var results = connection.QuerySingleOrDefault(sql, new { CustomerId = id });
                //return results
                return results;
            }
        }

        //Update values order table with the new values
        public int Update(Order entity)
        {
            //sql statement that is updateing the values in orders table 
            var sql = "UPDATE Orders SET OrderId = @OrderId, OrderNumber = @OrderNumber,CustomerId = @CustomerId AND ShoppingCartId = @ShoppingCartId";
            //establishing  a connection
            using (var connection = _connectionFactory.GetConnection)
            {
                //opening the connection
                connection.Open();
                //excuting the sql statement and passing in the object of order
                var results = connection.Execute(sql, entity);
                //return results
                return results;
            }
        }
    }
}

