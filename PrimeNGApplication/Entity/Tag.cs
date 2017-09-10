using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Entity
{
    [Table("Tag")]
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
