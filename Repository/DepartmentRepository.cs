using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Repository
{
    public class DepartmentRepository: IDepartment
    {
        private DBContext db;
        public DepartmentRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Department> GetDepartments => db.Departments;

        public void Add(Department _Department)
        {
            db.Departments.Add(_Department);
            db.SaveChanges();
        }

        public Department GetDepartment(int? Id)
        {
            return db.Departments.Find(Id);
        }

        public void Remove(int? Id)
        {
            Department dbEntity = db.Departments.Find(Id);
            db.Departments.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
