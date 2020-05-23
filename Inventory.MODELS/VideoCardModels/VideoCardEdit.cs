using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.VideoCardModels
{
    public class VideoCardEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Chipset { get; set; }

        [Required]
        [Display(Name = "Memory Type")]
        public string MemoryType { get; set; }

        [Required]
        [Display(Name = "Core Clock Speed")]

        public int CoreClock { get; set; }

        [Required]
        [Display(Name = "Boosted Clock Speed")]

        public int BoostClock { get; set; }

        [Required]
        [Display(Name = "SLI or Crossfire")]

        public string SLICrossfire { get; set; }

        [Required]
        [Display(Name = "Frame Sync")]

        public string FrameSync { get; set; }

        [Required]
        public int Length { get; set; }

        [Required]
        [Display(Name = "Thermal Design Power")]

        public int ThermalDesignPower { get; set; }


        [Required]
        [Display(Name = "DVI Port Count")]
        public int DVIPorts { get; set; }

        [Required]
        [Display(Name = "HDMI Port Count")]

        public int HDMIPorts { get; set; }

        [Required]
        [Display(Name = "Mini HDMI Port Count")]

        public int MiniHDMIPorts { get; set; }

        [Required]
        [Display(Name = "Display Port Count")]

        public int DisplayPorts { get; set; }

        [Required]
        [Display(Name = "Expansion Slot Width")]

        public int ExpansionSlotWidth { get; set; }

        [Required]
        public string Cooling { get; set; }

        [Required]
        [Display(Name = "In use")]
        public bool IsAvailable { get; set; }
    }
}
