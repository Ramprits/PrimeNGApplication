using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("PersonPhone", Schema = "Person")]
    public partial class PersonPhone
    {
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Column(TypeName = "Phone")]
        public string PhoneNumber { get; set; }
        [Column("PhoneNumberTypeID")]
        public int PhoneNumberTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("BusinessEntityId")]
        [InverseProperty("PersonPhone")]
        public virtual Person BusinessEntity { get; set; }
        [ForeignKey("PhoneNumberTypeId")]
        [InverseProperty("PersonPhone")]
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
