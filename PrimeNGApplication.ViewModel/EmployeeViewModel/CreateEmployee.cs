using System.ComponentModel.DataAnnotations;

namespace PrimeNGApplication.ViewModel.EmployeeViewModel
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
