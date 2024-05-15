using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S_W_HealthStore.Models;
namespace S_W.DB.Interfaces
{
    public interface IProductRepository:IgenericRepository<Product>
    {
        //stores product in a list and gets them by name
        List<Product> GetByName(string name);
    }
}
