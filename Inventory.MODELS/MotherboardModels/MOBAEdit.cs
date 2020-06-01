using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.MotherboardModels
{
    public class MOBAEdit
    {
        [Required]
        public int MotherboardId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Socket { get; set; }

        [Required]
        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }

        [Required]
        [Display(Name = "Maxium Memory")]
        public int MemoryMax { get; set; }

        [Required]
        [Display(Name = "Memeory Slots")]
        public int MemorySlots { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Chipset { get; set; }

        [Required]
        [Display(Name = "PCI-E X16 Slots")]
        public int PCIEX16Slots { get; set; }

        [Required]
        [Display(Name = "PCI-E X8 Slots")]
        public int PCIEX8Slots { get; set; }

        [Required]
        [Display(Name = "PCI-E X4 Slots")]
        public int PCIEX4Slots { get; set; }

        [Required]
        [Display(Name = "PCI Slots")]
        public int PCISlots { get; set; }

        [Required]
        [Display(Name = "Ethernet Ports")]
        public int EthernetPorts { get; set; }

        [Required]
        [Display(Name = "M.2 Slots")]
        public int M2Slots { get; set; }

        [Required]
        [Display(Name = "Sata 3GB/S Ports")]
        public int Sata3GBsPorts { get; set; }

        [Required]
        [Display(Name = "Sata 6GB/S Ports")]
        public int Sata6GBsPorts { get; set; }

        [Required]
        [Display(Name = "Sata Express Ports")]
        public int SataExpressPorts { get; set; }

        [Required]
        [Display(Name = "MSATA Slots")]
        public int MSataSlots { get; set; }

        [Required]
        [Display(Name = "Onboard Video")]
        public bool OnboardVideo { get; set; }

        [Required]
        [Display(Name="Onboard USB 3.0 Headers")]
        public bool OnboardUSB3Headers { get; set; }

        [Required]
        [Display(Name="Wifi Networking")]
        public bool WifiNetworking { get; set; }

        [Required]
        [Display(Name="In use?")]
        public bool IsAvailable { get; set; }
    }
}
