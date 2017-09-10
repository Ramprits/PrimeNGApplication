using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("CountryRegionCurrency", Schema = "Sales")]
    public partial class CountryRegionCurrency
    {
        [MaxLength(3)]
        public string CountryRegionCode { get; set; }
        [Column(TypeName = "nchar(3)")]
        public string CurrencyCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("CountryRegionCode")]
        [InverseProperty("CountryRegionCurrency")]
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        [ForeignKey("CurrencyCode")]
        [InverseProperty("CountryRegionCurrency")]
        public virtual Currency CurrencyCodeNavigation { get; set; }
    }
}
