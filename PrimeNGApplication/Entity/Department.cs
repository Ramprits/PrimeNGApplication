using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Entity
{
    [Table("Department", Schema = "mst")]
    public partial class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
