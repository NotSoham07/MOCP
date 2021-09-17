using System;
using System.Collections.Generic;
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
        Days10,Days15
    }
    public class Employee
    {
        [Key]
        public int MocNo { get; set; }
        public string EmpName { get; set; }
        public int EmpId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public TypeofChange? TypeofChange { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateofJoining { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateofTransfer { get; set; }
        public TimeFrame? TimeFrame { get; set; }

    }
}
