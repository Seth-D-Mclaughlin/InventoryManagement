using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.MotherboardModels
{
    public class MOBADetail
    {
        public int Id { get; set; }

        public string Name { get; set; }

        
        public string Manufacturer { get; set; }

        
        public string Socket { get; set; }

        
        public string FormFactor { get; set; }

        
        public int MemoryMax { get; set; }

        
        public int MemorySlots { get; set; }

        
        public string Color { get; set; }

        
        public string Chipset { get; set; }

        
        public int PCIEX16Slots { get; set; }

        
        public int PCIEX8Slots { get; set; }

        
        public int PCIEX4Slots { get; set; }

        
        public int PCISlots { get; set; }

        
        public int EthernetPorts { get; set; }

        
        public int M2Slots { get; set; }

        
        public int Sata3GBsPorts { get; set; }

        
        public int Sata6GBsPorts { get; set; }

        
        public int SataExpressPorts { get; set; }

        
        public int MSataSlots { get; set; }

        
        public bool OnboardVideo { get; set; }

        
        public bool OnboardUSB3Headers { get; set; }

        
        public bool WifiNetworking { get; set; }

        
        public bool IsAvailable { get; set; }
    }
}
