using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOCP.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        [DisplayName("Position Name")]
        [Required(ErrorMessage = "Position Name is required")]
        public string PositionName { get; set; }
    }
}
