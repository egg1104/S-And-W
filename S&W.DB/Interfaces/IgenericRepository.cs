using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_W.DB.Interfaces
{
    public interface IgenericRepository<T> where T : class
    {
        //Gets objects by id
        T GetById(int id);
        //Gets all Objects and stores it in a list
        List<T> GetAll();
        int Add(T entity);
        //Updates objects
        int Update(T entity);
        //deletes objects
        int Delete(int id);
    }
}
