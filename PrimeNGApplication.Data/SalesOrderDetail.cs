using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("SalesOrderDetail", Schema = "Sales")]
    public partial class SalesOrderDetail
    {
        [Column("SalesOrderID")]
        public int SalesOrderId { get; set; }
        [Column("SalesOrderDetailID")]
        public int SalesOrderDetailId { get; set; }
        [MaxLength(25)]
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }
        [Column(TypeName = "numeric")]
        public decimal LineTotal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("SalesOrderId")]
        [InverseProperty("SalesOrderDetail")]
        public virtual SalesOrderHeader SalesOrder { get; set; }
        [ForeignKey("SpecialOfferId,ProductId")]
        [InverseProperty("SalesOrderDetail")]
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
