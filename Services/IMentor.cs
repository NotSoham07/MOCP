using MOCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Services
{
    public interface IMentor
    {
        IEnumerable<Mentor> GetMentors { get; }
        Mentor GetMentor(int Id);
        void Add(Mentor _Mentor);
        void Remove(int Id);
    }
}
