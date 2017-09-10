using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("ProductInventory", Schema = "Production")]
    public partial class ProductInventory
    {
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column("LocationID")]
        public short LocationId { get; set; }
        [Required]
        [MaxLength(10)]
        public string Shelf { get; set; }
        public byte Bin { get; set; }
        public short Quantity { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("LocationId")]
        [InverseProperty("ProductInventory")]
        public virtual Location Location { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ProductInventory")]
        public virtual Product Product { get; set; }
    }
}
