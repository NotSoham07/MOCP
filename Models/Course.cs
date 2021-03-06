using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public class Course
    {
        [Key]
        [DisplayName("Course Id")]
        [Required(ErrorMessage = "Course Id is required")]
        public int CourseId { get; set; }

        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course Name is required")]
        public string CourseName { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public int DepartmentId { get; set; }
        [DisplayName("Mentor Name")]
        [Required(ErrorMessage = "Mentor Name is required")]
        public int MentorId { get; set; }
      
        public Department Departments { get; set; }
       
        public Mentor Mentors { get; set; }

    }
}
