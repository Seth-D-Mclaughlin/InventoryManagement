using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.MemeoryModels
{
    public class MemoryDetail
    {
        public int MemoryId { get; set; }
        public string Name { get; set; }


        public string Manufacturer { get; set; }


        public string Speed { get; set; }


        public string Type { get; set; }


        public string Modules { get; set; }


        [Display(Name = "CAS Latency")]
        public int CASLatency { get; set; }


        public float Voltage { get; set; }


        public string Timing { get; set; }


        [Display(Name = "Heat Spreader")]

        public bool HeatSpreader { get; set; }


        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
