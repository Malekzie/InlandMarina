using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marina.Models
{
    public class Slip
    {
        [Key]
        public int ID { get; set; }
        public int DockId { get; set; }

        public int Width { get; set; }
        public int Length { get; set; }

        [ForeignKey("DockId")]
        public virtual Dock Dock { get; set; }

        // Navigation Property
        public virtual ICollection<Lease> Leases { get; set; }

        public bool IsAvailable => !Leases.Any();
    }
}
