using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.DATA
{
    public class Memory
    {
        [Key]
        [Required]
        public int MemoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Speed { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Modules { get; set; }

        [Required]
        public int CASLatency { get; set; }

        [Required]
        public float Voltage { get; set; }

        [Required]
        public string Timing { get; set; }

        [Required]
        public bool HeatSpreader { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        //public int? ProjectId { get; set; }
        //[ForeignKey(nameof(ProjectId))]
        //public virtual Project Project { get; set; }
    }
}
