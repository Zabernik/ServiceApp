using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Tickets")]
    public class TicketsEntity
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        public int? MachineId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }    
        public int Priority { get; set; }
    }
}
