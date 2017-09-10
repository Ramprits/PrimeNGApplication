using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("Person", Schema = "Person")]
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }

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
        [Column(TypeName = "xml")]
        public string AdditionalContactInfo { get; set; }
        [Column(TypeName = "xml")]
        public string Demographics { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual Employee Employee { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual Password Password { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        [InverseProperty("BusinessEntity")]
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
        [ForeignKey("BusinessEntityId")]
        [InverseProperty("Person")]
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
