using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public class Mentor
    {
        [Key]
        public int MentorId { get; set; }
        public string MentorName { get; set; }
        public int DepartmentId { get; set; }
    }
}
