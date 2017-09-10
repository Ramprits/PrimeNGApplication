using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("StateProvince", Schema = "Person")]
    public partial class StateProvince
    {
        public StateProvince()
        {
            Address = new HashSet<Address>();
            SalesTaxRate = new HashSet<SalesTaxRate>();
        }

        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }
        [Required]
        [Column(TypeName = "nchar(3)")]
        public string StateProvinceCode { get; set; }
        [Required]
        [MaxLength(3)]
        public string CountryRegionCode { get; set; }
        [Column(TypeName = "Flag")]
        public bool IsOnlyStateProvinceFlag { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column("TerritoryID")]
        public int TerritoryId { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("StateProvince")]
        public virtual ICollection<Address> Address { get; set; }
        [InverseProperty("StateProvince")]
        public virtual ICollection<SalesTaxRate> SalesTaxRate { get; set; }
        [ForeignKey("CountryRegionCode")]
        [InverseProperty("StateProvince")]
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        [ForeignKey("TerritoryId")]
        [InverseProperty("StateProvince")]
        public virtual SalesTerritory Territory { get; set; }
    }
}
