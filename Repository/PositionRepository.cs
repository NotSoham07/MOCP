using MOCP.Models;
using MOCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Repository
{
    public class PositionRepository:IPosition
    {
        private DBContext db;
        public PositionRepository(DBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Position> GetPositions => db.Positions;

        public void Add(Position _Position)
        {
            db.Positions.Add(_Position);
            db.SaveChanges();
        }

        public Position GetPosition(int? Id)
        {
            return db.Positions.Find(Id);

        }

        public void Remove(int? Id)
        {
            Position dbEntity = db.Positions.Find(Id);
            db.Positions.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
