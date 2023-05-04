using EF_CRUD_Operations.Context;
using EF_CRUD_Operations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_Operations.Repositories
{
    internal class EmployeeRepository
    {
        public EmployeeRepository()
        {
            db = new NorthwindContext();
        }
        NorthwindContext db;

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = db.Employees.ToList();
            return employees;
        }
    }
}
