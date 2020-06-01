using Inventory.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.PSUModels
{
    public class PSUEdit
    {
        [Required]
        public int PsuId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "Effeciency Rating")]
        public string EffeciencyRating { get; set; }

        [Required]
        [Display(Name = "Type of Modular")]
        public ModularType TypeOfModular { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public bool Fanless { get; set; }

        [Required]
        [Display(Name = "ATX Connectors")]
        public string ATXConnectors { get; set; }

        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
