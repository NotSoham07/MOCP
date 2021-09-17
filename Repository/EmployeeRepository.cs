using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private DBContext db;
        public EmployeeRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Employee> GetEmployees => db.Employees;

        public void Add(Employee _Employee)
        {
            db.Employees.Add(_Employee);
            db.SaveChanges();
        }

        public Employee GetEmployee(int Id)
        {
            Employee dbEntity = db.Employees.Find(Id);
            return dbEntity;
        }

        public void Remove(int Id)
        {
            Employee dbEntity = db.Employees.Find(Id);
            db.Employees.Remove(dbEntity);
            db.SaveChanges();

        }
    }
}
