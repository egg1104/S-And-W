using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_W.DB.Interfaces
{
    public interface IConnectionFactory
    {
        //Open source for data connection called GetConnection
        IDbConnection GetConnection { get; }
    }
}
