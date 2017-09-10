using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("UnitMeasure", Schema = "Production")]
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            ProductSizeUnitMeasureCodeNavigation = new HashSet<Product>();
            ProductWeightUnitMeasureCodeNavigation = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
        }

        [Column(TypeName = "nchar(3)")]
        public string UnitMeasureCode { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("UnitMeasureCodeNavigation")]
        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }
        [InverseProperty("SizeUnitMeasureCodeNavigation")]
        public virtual ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; set; }
        [InverseProperty("WeightUnitMeasureCodeNavigation")]
        public virtual ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; set; }
        [InverseProperty("UnitMeasureCodeNavigation")]
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
    }
}
