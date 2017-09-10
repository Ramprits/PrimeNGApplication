using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("SalesTaxRate", Schema = "Sales")]
    public partial class SalesTaxRate
    {
        [Column("SalesTaxRateID")]
        public int SalesTaxRateId { get; set; }
        [Column("StateProvinceID")]
        public int StateProvinceId { get; set; }
        public byte TaxType { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal TaxRate { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("StateProvinceId")]
        [InverseProperty("SalesTaxRate")]
        public virtual StateProvince StateProvince { get; set; }
    }
}
