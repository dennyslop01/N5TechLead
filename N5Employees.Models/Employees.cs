using System;
using System.Collections.Generic;
using System.Text;

namespace N5Employees.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ContractDate { get; set; }
        public bool Active { get; set; }
    }
}
