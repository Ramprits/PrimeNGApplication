using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Vendor", Schema = "Purchasing")]
    public partial class Vendor
    {
        public Vendor()
        {
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Required]
        [Column(TypeName = "AccountNumber")]
        public string AccountNumber { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        public byte CreditRating { get; set; }
        [Column(TypeName = "Flag")]
        public bool PreferredVendorStatus { get; set; }
        [Column(TypeName = "Flag")]
        public bool ActiveFlag { get; set; }
        [Column("PurchasingWebServiceURL")]
        [MaxLength(1024)]
        public string PurchasingWebServiceUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("BusinessEntity")]
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        [ForeignKey("BusinessEntityId")]
        [InverseProperty("Vendor")]
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
