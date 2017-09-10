using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("SalesTerritory", Schema = "Sales")]
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            Customer = new HashSet<Customer>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPerson = new HashSet<SalesPerson>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            StateProvince = new HashSet<StateProvince>();
        }

        [Column("TerritoryID")]
        public int TerritoryId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(3)]
        public string CountryRegionCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string Group { get; set; }
        [Column("SalesYTD", TypeName = "money")]
        public decimal SalesYtd { get; set; }
        [Column(TypeName = "money")]
        public decimal SalesLastYear { get; set; }
        [Column("CostYTD", TypeName = "money")]
        public decimal CostYtd { get; set; }
        [Column(TypeName = "money")]
        public decimal CostLastYear { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("Territory")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("Territory")]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        [InverseProperty("Territory")]
        public virtual ICollection<SalesPerson> SalesPerson { get; set; }
        [InverseProperty("Territory")]
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        [InverseProperty("Territory")]
        public virtual ICollection<StateProvince> StateProvince { get; set; }
        [ForeignKey("CountryRegionCode")]
        [InverseProperty("SalesTerritory")]
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
    }
}
