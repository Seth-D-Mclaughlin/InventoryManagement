using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.VideoCardModels
{
    public class VideoCardDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Chipset { get; set; }
        [Display(Name = "Memory Type")]
        public string MemoryType { get; set; }
        [Display(Name = "Core Clock Speed")]

        public int CoreClock { get; set; }
        [Display(Name = "Boosted Clock Speed")]

        public int BoostClock { get; set; }
        [Display(Name = "SLI or Crossfire")]

        public string SLICrossfire { get; set; }
        [Display(Name = "Frame Sync")]

        public string FrameSync { get; set; }
        public int Length { get; set; }
        [Display(Name = "Thermal Design Power")]

        public int ThermalDesignPower { get; set; }
        [Display(Name = "DVI Port Count")]
        public int DVIPorts { get; set; }
        [Display(Name = "HDMI Port Count")]

        public int HDMIPorts { get; set; }
        [Display(Name = "Mini HDMI Port Count")]

        public int MiniHDMIPorts { get; set; }
        [Display(Name = "Display Port Count")]

        public int DisplayPorts { get; set; }
        [Display(Name = "Expansion Slot Width")]

        public int ExpansionSlotWidth { get; set; }
        public string Cooling { get; set; }
        [Display(Name = "In use")]
        public bool IsAvailable { get; set; }

    }
}
