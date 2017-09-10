using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Store", Schema = "Sales")]
    public partial class Store
    {
       

        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column("SalesPersonID")]
        public int? SalesPersonId { get; set; }
        [Column(TypeName = "xml")]
        public string Demographics { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; } = new Guid();
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Customer> Customer { get; set; } = new List<Customer>();
        [ForeignKey("BusinessEntityId")]
        [InverseProperty("Store")]
        public virtual BusinessEntity BusinessEntity { get; set; }
        [ForeignKey("SalesPersonId")]
        [InverseProperty("Store")]
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
