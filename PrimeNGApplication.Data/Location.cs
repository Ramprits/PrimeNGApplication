using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Location", Schema = "Production")]
    public partial class Location
    {
        public Location()
        {
            ProductInventory = new HashSet<ProductInventory>();
            WorkOrderRouting = new HashSet<WorkOrderRouting>();
        }

        [Column("LocationID")]
        public short LocationId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string Name { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal CostRate { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Availability { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("Location")]
        public virtual ICollection<ProductInventory> ProductInventory { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<WorkOrderRouting> WorkOrderRouting { get; set; }
    }
}
