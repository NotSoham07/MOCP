using Microsoft.EntityFrameworkCore;
using MOCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Repository
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Mentor> Mentors { get; set; }

    }
}
