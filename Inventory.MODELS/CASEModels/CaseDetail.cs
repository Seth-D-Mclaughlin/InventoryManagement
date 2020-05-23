using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.CASEModels
{
    public class CaseDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Color { get; set; }

        [Display(Name = "Power Supply")]
        public string PowerSupply { get; set; }

        [Display(Name = "Tower Size")]
        public string Type { get; set; }

        [Display(Name = "Side Panel Material")]

        public string SidePanelWindow { get; set; }

        [Display(Name = "Is there PSU shroud")]

        public bool PowerSupplyShroud { get; set; }

        [Display(Name = "Front Panel USB")]

        public string FrontPanelUSB { get; set; }

        [Display(Name = "Motherboard Form Factor")]

        public string MotherboardFormFactor { get; set; }

        [Display(Name = "External 5.2 Bay count")]

        public int External52Bay { get; set; }

        [Display(Name = "External 3.5 Bay count")]

        public int External35Bay { get; set; }

        [Display(Name = "Internal 3.5 Bay count")]

        public int Internal35Bay { get; set; }

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
