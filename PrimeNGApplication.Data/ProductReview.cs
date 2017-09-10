using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("ProductReview", Schema = "Production")]
    public partial class ProductReview
    {
        [Column("ProductReviewID")]
        public int ProductReviewId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "Name")]
        public string ReviewerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReviewDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        public int Rating { get; set; }
        [MaxLength(3850)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("ProductReview")]
        public virtual Product Product { get; set; }
    }
}
