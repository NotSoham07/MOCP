using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Repository
{
    public class CourseRepository:ICourse
    {
        private DBContext db;
        public CourseRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Course> GetCourses => db.Courses;

        public void Add(Course _Course)
        {
            db.Courses.Add(_Course);
            db.SaveChanges();
        }

        public Course GetCourse(int Id)
        {
            return db.Courses.Find(Id);
        }

        public void Remove(int Id)
        {
            Course dbEntity = db.Courses.Find(Id);
            db.Courses.Remove(dbEntity);
            db.SaveChanges();

        }
    }
}
