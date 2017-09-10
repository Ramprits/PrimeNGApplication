using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Employee_Temporal", Schema = "HumanResources")]
    public partial class EmployeeTemporal
    {
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Required]
        [Column("NationalIDNumber")]
        [MaxLength(15)]
        public string NationalIdnumber { get; set; }
        [Required]
        [Column("LoginID")]
        [MaxLength(256)]
        public string LoginId { get; set; }
        public short? OrganizationLevel { get; set; }
        [Required]
        [MaxLength(50)]
        public string JobTitle { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Column(TypeName = "nchar(1)")]
        public string MaritalStatus { get; set; }
        [Required]
        [Column(TypeName = "nchar(1)")]
        public string Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
