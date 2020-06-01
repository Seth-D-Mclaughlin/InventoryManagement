using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.CASEModels
{
    public class CaseEdit
    {
        [Required]
        public int CaseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Power Supply")]
        public string PowerSupply { get; set; }

        [Required]
        [Display(Name = "Tower Size")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Side Panel Material")]

        public string SidePanelWindow { get; set; }

        [Required]
        [Display(Name = "Is there PSU shroud")]

        public bool PowerSupplyShroud { get; set; }

        [Required]
        [Display(Name = "Front Panel USB")]

        public string FrontPanelUSB { get; set; }

        [Required]
        [Display(Name = "Motherboard Form Factor")]

        public string MotherboardFormFactor { get; set; }

        [Required]
        [Display(Name = "External 5.2 Bay count")]

        public int External52Bay { get; set; }

        [Required]
        [Display(Name = "External 3.5 Bay count")]

        public int External35Bay { get; set; }

        [Required]
        [Display(Name = "Internal 3.5 Bay count")]

        public int Internal35Bay { get; set; }

        [Required]
        [Display(Name = "Internal 2.5 Bay count")]

        public int Internal25Bay { get; set; }


        [Display(Name = "Full Height for Expansion Slot")]

        public int? FullHeightExpansionSlots { get; set; }


        [Display(Name = "Half Height for Expansion Slot")]

        public int? HalfHeightExpansionSlots { get; set; }

        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
