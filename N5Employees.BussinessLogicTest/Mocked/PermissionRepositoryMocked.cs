using AutoFixture;
using Moq;
using N5Employees.Models;
using N5Employees.Repositories;
using N5Employees.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace N5Employees.BussinessLogicTest.Mocked
{
    public class PermissionRepositoryMocked
    {
        private readonly List<Permission> _permissions;
        public PermissionRepositoryMocked()
        {
            _permissions = Permissions();
        }

        public IUnitOfWork GetInstance()
        {
            var mocked = new Mock<IUnitOfWork>();
            mocked.Setup(p => p.Permision).Returns(GetPermissionRepositoryMocked());

            return mocked.Object;
        }

        public IPermissionRepository GetPermissionRepositoryMocked()
        {
            var permissionMocked = new Mock<IPermissionRepository>();

            permissionMocked.Setup(c => c.GetPermissionsList(It.IsAny<int>()));
            //.Returns((int id) => _permissions.FirstOrDefault(pers => pers.IdEmployee == id));

            permissionMocked.Setup(c => c.Insert(It.IsAny<Permission>()))
                            .Callback<Permission>((c) => _permissions.Add(c))
                            .Returns<Permission>(c => c.IdEmployee);

            permissionMocked.Setup(c => c.Update(It.IsAny<Permission>()))
                            .Callback<Permission>((c) => { _permissions.RemoveAll(per => per.IdEmployee == c.IdEmployee); _permissions.Add(c); })
                            .Returns(true);


            return permissionMocked.Object;
        }

        private List<Permission> Permissions()
        {
            var fixture = new Fixture();
            var permission = fixture.CreateMany<Permission>(50).ToList();
            for(int i = 0; i < 50; i++)
            {
                permission[i].IdEmployee = i + 1;
            }

            return permission;
        }
    }
}
