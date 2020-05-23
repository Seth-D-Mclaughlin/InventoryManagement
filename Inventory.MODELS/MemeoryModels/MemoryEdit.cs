using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.MemeoryModels
{
    public class MemoryEdit
    {
        [Required]
        public int Id { get; set; }

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
        [Display(Name = "CAS Latency")]
        public int CASLatency { get; set; }

        [Required]
        public float Voltage { get; set; }

        [Required]
        public string Timing { get; set; }

        [Required]
        [Display(Name = "Heat Spreader")]

        public bool HeatSpreader { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
