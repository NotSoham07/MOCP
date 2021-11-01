using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public enum TypeofChange
    {
        NewJoiner,InterTransfer,IntraTransfer
    }
    public enum TimeFrame
    {
        TenDays, FifteenDays
    }
    public class Employee
    {
        [Key]
        public int MocNo { get; set; }
        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        public string EmpName { get; set; }
        [DisplayName("Employee ID")]
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmpId { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public int DepartmentId { get; set; }
        [DisplayName("Position Name")]
        [Required(ErrorMessage = "Position Name is required")]
        public int PositionId { get; set; }
        [DisplayName("Type of Change")]
        [Required(ErrorMessage = "Type of Change is required")]
        public string TypeofChange { get; set; }
        [DisplayName("Date of Joining")]
        [Required(ErrorMessage = "Date of Joining is required")]
        [DataType(DataType.Date)]
        public DateTime DateofJoining { get; set; }
        [DisplayName("Date of Transfer")]
        [Required(ErrorMessage = "Date of Transfer is required")]
        [DataType(DataType.Date)]
        public DateTime DateofTransfer { get; set; }
        [DisplayName("Time Frame")]
        [Required(ErrorMessage = "Time Frame is required")]
        public string TimeFrame { get; set; }
        
        public Department Departments { get; set; }
        public Position Positions { get; set; }
        public ICollection<Course> Courses { get; set; }
        

    }
}
