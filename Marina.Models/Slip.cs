﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Computed property to determine availability
        public bool IsAvailable => !Leases.Any(); // If there are no leases, the slip is available
    }
}
