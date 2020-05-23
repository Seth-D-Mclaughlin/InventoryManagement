using System.ComponentModel.DataAnnotations;

namespace Inventory.MODELS.CPUModels
{
    public class CPUDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Manufacturer { get; set; }


        [Display(Name = "Core Count")]
        public int CoreCount { get; set; }


        [Display(Name = "Core Clock")]
        public float CoreClock { get; set; }


        [Display(Name = "Core Boost Clock")]
        public float BoostClock { get; set; }


        public string Series { get; set; }


        public string MicroArchitecture { get; set; }


        [Display(Name = "Core Family")]

        public string CoreFamily { get; set; }


        public string Socket { get; set; }


        [Display(Name = "Integrated Graphics")]
        public bool IntegratedGraphics { get; set; }


        [Display(Name = "Simultaneous Multithreading")]
        public bool SimultaneousMultithreading { get; set; }


        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }


        [Display(Name = "Thermal Design Power")]
        public int ThermalDesignPower { get; set; }
    }
}
