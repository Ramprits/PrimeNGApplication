using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Employee", Schema = "HumanResources")]
    public partial class Employee
    {
        public Employee()
        {
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistory = new HashSet<EmployeePayHistory>();
            JobCandidate = new HashSet<JobCandidate>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

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
        [Column(TypeName = "Flag")]
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        [Column(TypeName = "Flag")]
        public bool CurrentFlag { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("BusinessEntity")]
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual ICollection<EmployeePayHistory> EmployeePayHistory { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual ICollection<JobCandidate> JobCandidate { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual SalesPerson SalesPerson { get; set; }
        [ForeignKey("BusinessEntityId")]
        [InverseProperty("Employee")]
        public virtual Person BusinessEntity { get; set; }
    }
}
