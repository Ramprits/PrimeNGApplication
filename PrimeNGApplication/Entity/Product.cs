using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNGApplication.Entity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "please enter product name"), MaxLength(25), MinLength(2)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "please enter product code"), MaxLength(25), MinLength(2)]
        public string ProductCode { get; set; }

        public DateTime? ReleaseDate { get; set; }
        public string MyProperty { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int StarRating { get; set; }
        public string ImageUrl { get; set; }

        public  ICollection<Tag> Tag { get; set; }

    }
}
