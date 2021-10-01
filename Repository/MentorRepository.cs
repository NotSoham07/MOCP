using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MOCP.Repository
{
    public class MentorRepository:IMentor
    {
        private DBContext db;
        public MentorRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Mentor> GetMentors => db.Mentors.Include(d => d.Departments);

        public void Add(Mentor _Mentor)
        {
            db.Mentors.Add(_Mentor);
            db.SaveChanges();
        }

        public Mentor GetMentor(int? Id)
        {
            return db.Mentors.Find(Id);
        }

        public void Remove(int? Id)
        {
            Mentor dbEntity = db.Mentors.Find(Id);
            db.Mentors.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
