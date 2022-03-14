using System.Collections.Generic;

namespace N5Employees.Repositories
{
    public interface IRepository <T> where T: class
    {
        int Insert(T entity);
        bool Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
