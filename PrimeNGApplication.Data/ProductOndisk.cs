using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Product_ondisk", Schema = "Production")]
    public partial class ProductOndisk
    {
        public ProductOndisk()
        {
            SpecialOfferProductOndisk = new HashSet<SpecialOfferProductOndisk>();
        }

        [Column("ProductID")]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        [MaxLength(15)]
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }
        [MaxLength(5)]
        public string Size { get; set; }
        [Column(TypeName = "nchar(3)")]
        public string SizeUnitMeasureCode { get; set; }
        [Column(TypeName = "nchar(3)")]
        public string WeightUnitMeasureCode { get; set; }
        [Column(TypeName = "decimal")]
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        [Column(TypeName = "nchar(2)")]
        public string ProductLine { get; set; }
        [Column(TypeName = "nchar(2)")]
        public string Class { get; set; }
        [Column(TypeName = "nchar(2)")]
        public string Style { get; set; }
        [Column("ProductSubcategoryID")]
        public int? ProductSubcategoryId { get; set; }
        [Column("ProductModelID")]
        public int? ProductModelId { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<SpecialOfferProductOndisk> SpecialOfferProductOndisk { get; set; }
    }
}
