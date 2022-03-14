using FluentAssertions;
using N5Employees.BussinessLogic.Implementatios;
using N5Employees.BussinessLogic.Interfaces;
using N5Employees.BussinessLogicTest.Mocked;
using N5Employees.Models;
using N5Employees.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace N5Employees.BussinessLogicTest
{
    public class PermissionLogicTest
    {
        private readonly IUnitOfWork _unitMocked;
        private readonly IPermissionLogic _permissionLogic;
        public PermissionLogicTest()
        {
            var unitMocked = new PermissionRepositoryMocked();
            _unitMocked = unitMocked.GetInstance();
            _permissionLogic = new PermissionLogic(_unitMocked);
        }

        [Fact]
        public void GetPermission_Test()
        {
            var result = _permissionLogic.GetPermissions(1);
            result.Should().NotBeNull();
            //result.IdEmployee.Should().BeGreaterThan(0);
        }

        [Fact]
        public void Insert_Permission_Test()
        {
            var permission = new Permission
            {
                IdEmployee = 1,
                IdPermissionType = 3
            };

            var result = _permissionLogic.Insert(permission);
            result.Should().Be(1);
        }

        [Fact]
        public void Update_Permission_Test()
        {
            var permission = new Permission
            {
                IdEmployee = 1,
                IdPermissionType = 3
            };

            var result = _permissionLogic.Insert(permission);
            result.Should().NotBe(null);
        }
    }
}
