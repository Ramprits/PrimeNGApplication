using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Person_json", Schema = "Person")]
    public partial class PersonJson
    {
        [Column("PersonID")]
        public int PersonId { get; set; }
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
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
