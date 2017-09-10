using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("EmailAddress", Schema = "Person")]
    public partial class EmailAddress
    {
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Column("EmailAddressID")]
        public int EmailAddressId { get; set; }
        [Column("EmailAddress")]
        [MaxLength(50)]
        public string EmailAddress1 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("BusinessEntityId")]
        [InverseProperty("EmailAddress")]
        public virtual Person BusinessEntity { get; set; }
    }
}
