using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MODELS.PSUModels
{
    public class PSUListItem
    {
        [Required]
        public int PsuId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [Display(Name = "ATX Connectors")]
        public string ATXConnectors { get; set; }
        [Required]
        [Display(Name = "In use?")]
        public bool IsAvailable { get; set; }
    }
}
