﻿using System.ComponentModel.DataAnnotations;

namespace Marina.Models
{
    public class Dock
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public bool WaterService { get; set; }
        public bool ElectricalService { get; set; }

        // Navigation Property
        public virtual ICollection<Slip> Slips { get; set; } = new List<Slip>();
    }
}
