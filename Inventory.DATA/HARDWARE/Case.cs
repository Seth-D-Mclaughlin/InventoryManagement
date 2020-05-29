using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.DATA
{
    public class Case
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string PowerSupply { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string SidePanelWindow { get; set; }

        [Required]
        public bool PowerSupplyShroud { get; set; }

        [Required]
        public string FrontPanelUSB { get; set; }

        [Required]
        public string MotherboardFormFactor { get; set; }

        [Required]
        public int External52Bay { get; set; }

        [Required]
        public int External35Bay { get; set; }

        [Required]
        public int Internal35Bay { get; set; }

        [Required]
        public int Internal25Bay { get; set; }


        public int? FullHeightExpansionSlots { get; set; }


        public int? HalfHeightExpansionSlots { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

        public List<Project> Projects { get; set; }
    }
}
