using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Entity
{
    [Table("Employee", Schema = "mst")]
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        public string Gender { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
