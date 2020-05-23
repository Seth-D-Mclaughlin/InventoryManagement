using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.CPUModels
{
    public class CPUEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "Core Count")]
        public int CoreCount { get; set; }

        [Required]
        [Display(Name = "Core Clock")]
        public float CoreClock { get; set; }

        [Required]
        [Display(Name = "Core Boost Clock")]
        public float BoostClock { get; set; }

        [Required]
        public string Series { get; set; }

        [Required]
        public string MicroArchitecture { get; set; }

        [Required]
        [Display(Name = "Core Family")]

        public string CoreFamily { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        [Display(Name = "Integrated Graphics")]
        public bool IntegratedGraphics { get; set; }

        [Required]
        [Display(Name = "Simultaneous Multithreading")]
        public bool SimultaneousMultithreading { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }

        [Required]
        [Display(Name = "Thermal Design Power")]
        public int ThermalDesignPower { get; set; }
    }
}
