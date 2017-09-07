using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
