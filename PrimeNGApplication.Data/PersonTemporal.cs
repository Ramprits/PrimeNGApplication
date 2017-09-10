using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Person_Temporal", Schema = "Person")]
    public partial class PersonTemporal
    {
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        [Required]
        [Column(TypeName = "nchar(2)")]
        public string PersonType { get; set; }
        [Column(TypeName = "NameStyle")]
        public bool NameStyle { get; set; }
        [MaxLength(8)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string FirstName { get; set; }
        [Column(TypeName = "Name")]
        public string MiddleName { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
