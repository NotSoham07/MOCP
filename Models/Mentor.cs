using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public class Mentor
    {
        [Key]
        public int MentorId { get; set; }
        [DisplayName("Mentor Name")]
        [Required(ErrorMessage = "Mentor Name is required")]
        public string MentorName { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public int DepartmentId { get; set; }

        public Department Departments { get; set; }
    }
}
