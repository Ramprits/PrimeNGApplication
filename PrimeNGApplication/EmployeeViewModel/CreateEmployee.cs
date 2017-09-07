using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNGApplication.EmployeeViewModel
{
    public class CreateEmployee
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string Gender { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
