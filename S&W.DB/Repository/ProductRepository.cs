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
    public class ProductRepository : IProductRepository
    {
        // this allows us to use the IconnectionFactory in this repository to establish a connection to the sql database
        private readonly IConnectionFactory _connectionFactory;

        //This is a constructor setting the _connectionFactory to conn
        public ProductRepository(IConnectionFactory conn)
        {
            _connectionFactory = conn;
        }

        //Adds values to products tables
        public int Add(Product entity)
        {
            var sql = "Insert into Products (Price,Quantity,Name) VALUES (@Price,@Quantity,@Name)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        //delete values from products table
        public int Delete(int id)
        {
            var sql = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Id = id });
                return result;
            }


        }

        //Gets all values from products table and stores them in a list of products
        public List<Product> GetAll()
        {
            var sql = "SELECT * FROM Products";


            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.Query<Product>(sql);
                return (List<Product>)results;

            }
        }


        //Gets values where id inputed in is equal to the id of the products table
        public Product GetById(int id)
        {
            var sql = "select * From Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault<Product>(sql, new { Id = id });
                return results;
            }
        }

        //retrieves all values from products table where they are all equil to the name input in and stored to a products list
        public List<Product> GetByName(string name)
        {
            var sql = "Select * From Products WHERE name = @Name";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault(sql, new { Name = name });
                return results;
            }
        }

        //Updates values in the products table
        public int Update(Product entity)
        {
            // ask instructor if i need to set it to productid, and product name
            var sql = "UPDATE products SET price = @Price, quantity = @Quantity , name = @Name where Id=@Id ";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.Execute(sql, entity);
                return results;
            }
        }
    }

}
