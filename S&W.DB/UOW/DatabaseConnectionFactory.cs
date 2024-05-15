using S_W.DB.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace S_W.DB.UOW
{
    public class DatabaseConnectionFactory : IConnectionFactory
    {
        //Method that places name in the conncectionStrings
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //sets name of connectionString 
        private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = SWDataBase";

        public IDbConnection GetConnection
        {
            get
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                return conn;
            }

        }
    }
}
