using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNGApplication.Models
{
    public abstract class DepartmentManipulationDto
    {
        [Required(ErrorMessage = "Please enter location Name"), MinLength(2), MaxLength(100)]
        public virtual string Location { get; set; }
        [Required(ErrorMessage = "Please enter  Name"), MinLength(2), MaxLength(100)]
        public virtual string Name { get; set; }
    }
}
