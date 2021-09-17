using MOCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Services
{
    public interface IPosition
    {
        IEnumerable<Position> GetPositions { get; }
        Position GetPosition(int? Id);
        void Add(Position _Position);
        void Remove(int? Id);
    }
}
