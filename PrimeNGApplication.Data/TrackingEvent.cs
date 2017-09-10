using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNGApplication.Data
{
    [Table("TrackingEvent", Schema = "Sales")]
    public partial class TrackingEvent
    {
        [Column("TrackingEventID")]
        public int TrackingEventId { get; set; }
        [Required]
        [MaxLength(255)]
        public string EventName { get; set; }
    }
}
