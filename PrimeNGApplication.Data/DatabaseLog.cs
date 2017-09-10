using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    public partial class DatabaseLog
    {
        [Column("DatabaseLogID")]
        public int DatabaseLogId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PostTime { get; set; }
        [Required]
        [Column(TypeName = "sysname")]
        public string DatabaseUser { get; set; }
        [Required]
        [Column(TypeName = "sysname")]
        public string Event { get; set; }
        [Column(TypeName = "sysname")]
        public string Schema { get; set; }
        [Column(TypeName = "sysname")]
        public string Object { get; set; }
        [Required]
        [Column("TSQL")]
        public string Tsql { get; set; }
        [Required]
        [Column(TypeName = "xml")]
        public string XmlEvent { get; set; }
    }
}
