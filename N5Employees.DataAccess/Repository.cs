using N5Employees.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace N5Employees.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionstring;
        public Repository(string conncectionstring)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{ type.Name }"; };
            _connectionstring = conncectionstring;
        }

        public T GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using(var connection = new SqlConnection(_connectionstring))
            {
                return (int) connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection.Update(entity);
            }
        }
    }
}
