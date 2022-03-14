using N5Employees.BussinessLogic.Interfaces;
using N5Employees.Models;
using N5Employees.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace N5Employees.BussinessLogic.Implementatios
{
    public class PermissionLogic : IPermissionLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public PermissionLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Permission> GetPermissions(int id)
        {
            return _unitOfWork.Permision.GetPermissionsList(id);
        }

        public int Insert(Permission permision)
        {
            return _unitOfWork.Permision.Insert(permision);
        }

        public bool Update(Permission permision)
        {
            return _unitOfWork.Permision.Update(permision);
        }
    }
}
