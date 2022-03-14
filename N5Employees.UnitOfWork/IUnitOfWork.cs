using N5Employees.Repositories;

namespace N5Employees.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPermissionRepository Permision { get; }
    }
}
