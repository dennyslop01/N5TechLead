using Dapper;
using N5Employees.Models;
using N5Employees.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace N5Employees.DataAccess
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(string connectionstring) : base (connectionstring)
        {

        }

        public IEnumerable<Permission> GetPermissionsList(int @idEmployee)
        {
            var param = new DynamicParameters();
            param.Add("@idEmployee", @idEmployee);
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Permission>("dbo.GetPermissions", param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
