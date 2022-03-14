using Microsoft.AspNetCore.Mvc;
using N5Employees.BussinessLogic.Interfaces;
using N5Employees.Models;
using N5Employees.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5Employees.WebApi.Controllers
{
    [Route("api/Permission")]
    public class PermssionController : Controller
    {
        private readonly IPermissionLogic _permissionLogic;
        public PermssionController(IPermissionLogic permissionLogic)
        {
            _permissionLogic = permissionLogic;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetPermissions(int id)
        {
            return Ok(_permissionLogic.GetPermissions(id));
        }

        [HttpPost]
        public IActionResult RequestPermission(Permission permision)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_permissionLogic.Insert(permision));
        }
        [HttpPut]
        public IActionResult ModifyPermission(Permission permision)
        {
            if (ModelState.IsValid && _permissionLogic.Update(permision))
                return Ok( new { Message = "Permisos Actualizdos" });

            return BadRequest();
        }


    }
}
