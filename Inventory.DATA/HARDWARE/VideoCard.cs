using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.DATA
{
    public class VideoCard
    {
        [Key]
        [Required]
        public int VideoId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Chipset { get; set; }

        [Required]
        public string MemoryType { get; set; }

        [Required]
        public int CoreClock { get; set; }

        [Required]
        public int BoostClock { get; set; }

        [Required]
        public string SLICrossfire { get; set; }

        [Required]
        public string FrameSync { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        public int ThermalDesignPower { get; set; }

        [Required]
        public int DVIPorts { get; set; }

        [Required]
        public int HDMIPorts { get; set; }

        [Required]
        public int MiniHDMIPorts { get; set; }

        [Required]
        public int DisplayPorts { get; set; }

        [Required]
        public int ExpansionSlotWidth { get; set; }

        [Required]
        public string Cooling { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        //public int? ProjectId { get; set; }
        //[ForeignKey(nameof(ProjectId))]
        //public virtual Project Project { get; set; }
    }
}
