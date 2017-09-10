using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("SalesOrder_json", Schema = "Sales")]
    public partial class SalesOrderJson
    {
        [Column("SalesOrderID")]
        public int SalesOrderId { get; set; }
        public byte RevisionNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShipDate { get; set; }
        public byte Status { get; set; }
        [Column(TypeName = "Flag")]
        public bool OnlineOrderFlag { get; set; }
        [Required]
        [MaxLength(25)]
        public string SalesOrderNumber { get; set; }
        [Column(TypeName = "OrderNumber")]
        public string PurchaseOrderNumber { get; set; }
        [Column(TypeName = "AccountNumber")]
        public string AccountNumber { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }
        [Column("TerritoryID")]
        public int? TerritoryId { get; set; }
        [Column("BillToAddressID")]
        public int? BillToAddressId { get; set; }
        [Column("ShipToAddressID")]
        public int? ShipToAddressId { get; set; }
        [Column("ShipMethodID")]
        public int? ShipMethodId { get; set; }
        [Column("CreditCardID")]
        public int? CreditCardId { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string CreditCardApprovalCode { get; set; }
        [Column("CurrencyRateID")]
        public int? CurrencyRateId { get; set; }
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        [Column(TypeName = "money")]
        public decimal TaxAmt { get; set; }
        [Column(TypeName = "money")]
        public decimal Freight { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalDue { get; set; }
        [MaxLength(128)]
        public string Comment { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
