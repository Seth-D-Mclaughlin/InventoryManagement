using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DATA
{
    public class Motherboard
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Manufacturer { get; set; }
        
        [Required]
        public string Socket { get; set; }
        
        [Required]
        public string FormFactor { get; set; }
        
        [Required]
        public int MemoryMax { get; set; }
        
        [Required]
        public int MemorySlots { get; set; }
        
        [Required]
        public string Color { get; set; }
        
        [Required]
        public string Chipset { get; set; }
        
        [Required]
        public int PCIEX16Slots { get; set; }
        
        [Required]
        public int PCIEX8Slots { get; set; }
        
        [Required]
        public int PCIEX4Slots { get; set; }
        
        [Required]
        public int PCISlots { get; set; }
        
        [Required]
        public int EthernetPorts { get; set; }
        
        [Required]
        public int M2Slots { get; set; }
        
        [Required]
        public int Sata3GBsPorts { get; set; }
        
        [Required]
        public int Sata6GBsPorts { get; set; }
        
        [Required]
        public int SataExpressPorts { get; set; }
        
        [Required]
        public int MSataSlots { get; set; }
        
        [Required]
        public bool OnboardVideo { get; set; }
        
        [Required]
        public bool OnboardUSB3Headers { get; set; }
        
        [Required]
        public bool WifiNetworking { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

    }
}
