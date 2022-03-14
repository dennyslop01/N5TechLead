using N5Employees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace N5Employees.BussinessLogic.Interfaces
{
    public interface IPermissionLogic
    {
        IEnumerable<Permission> GetPermissions(int id);
        int Insert(Permission permision);
        bool Update(Permission permision);

    }
}
