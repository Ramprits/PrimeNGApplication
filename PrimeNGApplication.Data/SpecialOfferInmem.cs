using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("SpecialOffer_inmem", Schema = "Sales")]
    public partial class SpecialOfferInmem
    {
        public SpecialOfferInmem()
        {
            SpecialOfferProductInmem = new HashSet<SpecialOfferProductInmem>();
        }

        [Column("SpecialOfferID")]
        public int SpecialOfferId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal DiscountPct { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        [Required]
        [MaxLength(50)]
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinQty { get; set; }
        public int? MaxQty { get; set; }
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("SpecialOffer")]
        public virtual ICollection<SpecialOfferProductInmem> SpecialOfferProductInmem { get; set; }
    }
}
