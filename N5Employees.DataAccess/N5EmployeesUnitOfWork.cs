using N5Employees.Repositories;
using N5Employees.UnitOfWork;

namespace N5Employees.DataAccess
{
    public class N5EmployeesUnitOfWork : IUnitOfWork
    {
        public N5EmployeesUnitOfWork(string connectionstring)
        {
            Permision = new PermissionRepository(connectionstring); 
        }

        public IPermissionRepository Permision { get; private set; }
    }
}
