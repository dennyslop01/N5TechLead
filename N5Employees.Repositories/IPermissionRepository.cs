using N5Employees.Models;
using System.Collections.Generic;

namespace N5Employees.Repositories
{
    public interface IPermissionRepository : IRepository<Permission>
    {
        IEnumerable<Permission> GetPermissionsList(int idEmployee); 
    }
}
