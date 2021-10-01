using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public string DepartmentName { get; set; }
        [DisplayName("Department Location")]
        [Required(ErrorMessage = "Department Location is required")]
        public string DepartmentLocation { get; set; }
    }
}
