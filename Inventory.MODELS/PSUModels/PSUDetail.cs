using Inventory.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.PSUModels
{
    public class PSUDetail
    {
        public int PsuId { get; set; }

        
        public string Name { get; set; }

        
        public string Manufacturer { get; set; }

        [Display(Name="Effeciency Rating")]

        public string EffeciencyRating { get; set; }

        [Display(Name = "Type of Modular")]

        public ModularType TypeOfModular { get; set; }

        
        public string Color { get; set; }

        
        public string Type { get; set; }

        
        public bool Fanless { get; set; }

        [Display(Name = "ATX Connectors")]
        public string ATXConnectors { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
